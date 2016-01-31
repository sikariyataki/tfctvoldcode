﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Gigya.Socialize.SDK;
using IPTV2_Model;
using TFCTV.Helpers;

namespace TFCTV.Controllers
{
    public class SocialController : Controller
    {
        //
        // GET: /Social/

        public ActionResult Index()
        {
            if (TempData["qs"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            NameValueCollection qs = (NameValueCollection)TempData["qs"];
            if (qs != null)
            {
                if (User.Identity.IsAuthenticated)
                {
                    try
                    {
                        var context = new IPTV2Entities();
                        var user = context.Users.FirstOrDefault(u => u.UserId == new Guid(User.Identity.Name));
                        if (user != null)
                        {
                            Dictionary<string, object> collection = new Dictionary<string, object>();
                            collection.Add("siteUID", user.UserId.ToString());
                            collection.Add("uid", Uri.UnescapeDataString(qs["UID"]));
                            collection.Add("cid", String.Format("{0} - New User", qs["provider"]));
                            GSResponse notifyRegistration = GigyaHelpers.createAndSendRequest("socialize.notifyRegistration", GigyaHelpers.buildParameter(collection));
                            if (notifyRegistration.GetErrorCode() == 0)
                            {
                                if (Request.UrlReferrer != null)
                                    return Redirect(Request.UrlReferrer.PathAndQuery);
                                return RedirectToAction("Index", "Home");
                            }

                        }
                    }
                    catch (Exception e) { MyUtility.LogException(e); }
                }

                TempData["qs"] = qs;
                ViewBag.provider = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(qs["provider"]);
                TempData["qs"] = qs;
            }
            return View();
        }

        //public ActionResult LinkAccount()
        //{
        //    return View();
        //}

        public ActionResult Login()
        {
            /**rbr**/
            //This will handle request using i.e. browser.
            var retUrl = Uri.UnescapeDataString(Request.QueryString["returl"]);

            NameValueCollection qs = Request.QueryString;
            string gigyaUID = Uri.UnescapeDataString(qs["UID"]);
            bool isRequestValid = SigUtils.ValidateUserSignature(gigyaUID, Uri.UnescapeDataString(qs["timestamp"]), GlobalConfig.GSsecretkey, Uri.UnescapeDataString(qs["signature"]));
            if (isRequestValid)
            {
                TempData["gid"] = gigyaUID;
                var isNewUser = !Convert.ToBoolean(qs["isSiteUID"]); // If isSiteUID=='false' , this means the UID was generated by Gigya, hence the user is new. !(false) == true
                if (isNewUser)
                {
                    TempData["qs"] = qs; //bring the parameters to the next view
                    return RedirectToAction("Index");
                }
                else
                {
                    //FormsAuthentication.SetAuthCookie(gigyaUID, true); //Authenticate user to our site.                    
                    var context = new IPTV2Entities();
                    User user = context.Users.FirstOrDefault(u => u.UserId == new System.Guid(gigyaUID));
                    if (!MyUtility.isUserLoggedIn())
                    {
                        if (user != null)
                        {
                            if (user.StatusId == GlobalConfig.Visible)
                            {
                                SetAutheticationCookie(gigyaUID);
                                SetSession(gigyaUID);
                                ContextHelper.SaveSessionInDatabase(context, user);
                            }
                        }
                        else
                        {
                            //Delete user if site is on UAT
                            if (GlobalConfig.isUAT)
                            {
                                Dictionary<string, string> collection = new Dictionary<string, string>();
                                collection.Add("uid", gigyaUID);
                                GSResponse res = GigyaHelpers.createAndSendRequest("socialize.deleteAccount", GigyaHelpers.buildParameter(collection));
                            }

                        }
                        //FIXED , ONLY ALLOW THEM IN IF STATUSID IS ACTIVE                        
                    }
                    /**rbr**/
                    var referrerUrl = "";
                    try
                    {
                        referrerUrl = Request.UrlReferrer.ToString();
                    }
                    catch (Exception)
                    {
                        //i.e browser may throw an exception
                        referrerUrl = retUrl;
                    }
                    return Redirect(referrerUrl); //goes back to the same page where user logs in.
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public virtual void SetAutheticationCookie(string uid)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(uid, true, GlobalConfig.FormsAuthenticationTimeout);
            //FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, uid, DateTime.Now, DateTime.Now.AddMonths(1), true, String.Empty, FormsAuthentication.FormsCookiePath);
            string encTicket = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
            cookie.Expires = DateTime.Now.AddMonths(1);
            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
        }

        public virtual void SetSession(string uid)
        {
            if (GlobalConfig.IsPreventionOfMultipleLoginEnabled)
            {
                HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
                FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                var cache = DataCache.Cache;
                string cacheKey = "SESSIONID:U:" + ticket.Name.ToUpper();
                if (GlobalConfig.UseDaysBasedOnCacheDurationForSessionStore)
                    cache.Put(cacheKey, authCookie.Value, new TimeSpan(GlobalConfig.SessionStoreCacheDurationInDays, 0, 0, 0));
                else
                    cache.Put(cacheKey, authCookie.Value, new TimeSpan(ticket.Expiration.Ticks));
            }
        }

        public ActionResult Socialize()
        {
            var retUrl = String.Empty;

            try
            {
                NameValueCollection qs = Request.QueryString;
                string gigyaUID = Uri.UnescapeDataString(qs["UID"]);
                bool isRequestValid = SigUtils.ValidateUserSignature(gigyaUID, Uri.UnescapeDataString(qs["timestamp"]), GlobalConfig.GSsecretkey, Uri.UnescapeDataString(qs["signature"]));
                if (isRequestValid)
                {
                    using (var context = new IPTV2Entities())
                    {
                        User user = null;
                        bool isSiteUID = Convert.ToBoolean(qs["isSiteUID"]);
                        if (isSiteUID) //Old user. Signin to site
                        {
                            var UserId = new Guid(gigyaUID);
                            user = context.Users.FirstOrDefault(u => u.UserId == UserId);
                            if (user != null)
                            {
                                if (user.StatusId == GlobalConfig.Visible)
                                {
                                    try
                                    {
                                        if (TempData["RedirectUrl"] != null)
                                            retUrl = (string)TempData["RedirectUrl"];
                                    }
                                    catch (Exception) { }

                                    SetAutheticationCookie(gigyaUID);
                                    SetSession(gigyaUID);
                                    ContextHelper.SaveSessionInDatabase(context, user);
                                    SetUserTrackingCookie(UserId.ToString());
                                    try
                                    {
                                        //redirect to RedirectUrl
                                        //if (!String.IsNullOrEmpty(retUrl))
                                        //    return Redirect(retUrl);
                                        //var referrerUrl = Request.UrlReferrer.PathAndQuery;
                                        //return Redirect(referrerUrl);

                                        if (MyUtility.isTVECookieValid())
                                        {
                                            MyUtility.RemoveTVECookie();
                                            return RedirectToAction("RegisterToTFCEverywhere", "User");
                                        }
                                        if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("redirectaintone"))
                                        {
                                            HttpCookie tempCookie = new HttpCookie("redirectaintone");
                                            tempCookie.Expires = DateTime.Now.AddDays(-1);
                                            Response.Cookies.Add(tempCookie);
                                            return RedirectToAction("Details", "Subscribe", new { id = "aintone" });
                                        }
                                        //redirect to RedirectUrl
                                        if (!String.IsNullOrEmpty(retUrl))
                                        {
                                            try
                                            {
                                                if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                                    retUrl = new Uri(retUrl).GetLeftPart(UriPartial.Path);
                                            }
                                            catch (Exception) { }
                                            return Redirect(retUrl);
                                        }

                                        var referrerUrl = Request.UrlReferrer.PathAndQuery;
                                        if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                            referrerUrl = Request.UrlReferrer.GetLeftPart(UriPartial.Path);
                                        return Redirect(referrerUrl);
                                    }
                                    catch (Exception) { }
                                }
                                else //user is not active in the database, put code here                                
                                    TempData["LoginErrorMessage"] = "Social networking account is not verified in our system.";
                            }
                            else //user does not exist on database, put code here                            
                                TempData["LoginErrorMessage"] = "Social networking account does not exist in our system.";
                        }
                        else //New user. allow user to register
                        {
                            bool createUser = true;
                            if (!String.IsNullOrEmpty(qs["email"]))
                            {
                                string email = qs["email"];
                                user = context.Users.FirstOrDefault(u => String.Compare(u.EMail, email, true) == 0);
                                if (user != null) // link account
                                {
                                    Dictionary<string, object> collection = new Dictionary<string, object>();
                                    collection.Add("siteUID", user.UserId);
                                    collection.Add("uid", Uri.UnescapeDataString(qs["UID"]));
                                    collection.Add("cid", String.Format("{0} - New User", qs["provider"]));

                                    GSObject obj = new GSObject(Newtonsoft.Json.JsonConvert.SerializeObject(collection));
                                    GSResponse res = GigyaHelpers.createAndSendRequest("socialize.notifyRegistration", obj);
                                    if (res.GetErrorCode() == 0) //Successful link
                                    {
                                        try
                                        {
                                            if (TempData["RedirectUrl"] != null)
                                                retUrl = (string)TempData["RedirectUrl"];
                                        }
                                        catch (Exception) { }

                                        var UserId = user.UserId.ToString();
                                        user.StatusId = GlobalConfig.Visible; //activate account
                                        user.DateVerified = DateTime.Now;
                                        SetAutheticationCookie(UserId);
                                        SetSession(UserId);
                                        SetUserTrackingCookie(UserId);
                                        if (!ContextHelper.SaveSessionInDatabase(context, user))
                                            context.SaveChanges();
                                        try
                                        {
                                            //redirect to RedirectUrl
                                            if (!String.IsNullOrEmpty(retUrl))
                                            {
                                                try
                                                {
                                                    if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                                        retUrl = new Uri(retUrl).GetLeftPart(UriPartial.Path);
                                                }
                                                catch (Exception) { }
                                                return Redirect(retUrl);
                                            }

                                            var referrerUrl = Request.UrlReferrer.PathAndQuery;
                                            if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                                referrerUrl = Request.UrlReferrer.GetLeftPart(UriPartial.Path);
                                            return Redirect(referrerUrl);
                                        }
                                        catch (Exception) { }
                                    }
                                }
                            }

                            if (createUser)
                            {
                                TempData["qs"] = qs;
                                if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                    return Redirect("/WatchNow");
                                //return RedirectToAction("Index", "Air");

                                //redirect to RedirectUrl
                                if (!String.IsNullOrEmpty(retUrl))
                                {
                                    try
                                    {
                                        if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                                            retUrl = new Uri(retUrl).GetLeftPart(UriPartial.Path);
                                    }
                                    catch (Exception) { }
                                    return Redirect(retUrl);
                                }

                                return RedirectToAction("Register", "User");
                            }

                        }
                    }
                }
            }
            catch (Exception e) { MyUtility.LogException(e); }

            if (MyUtility.isTVECookieValid())
            {
                MyUtility.RemoveTVECookie();
                return RedirectToAction("RegisterToTFCEverywhere", "User");
            }

            if (!String.IsNullOrEmpty(retUrl))//redirect to RedirectUrl
            {
                try
                {
                    if (!String.IsNullOrEmpty(Request.QueryString["source"]))
                        retUrl = new Uri(retUrl).GetLeftPart(UriPartial.Path);
                }
                catch (Exception) { }
                return Redirect(retUrl);
            }

            return RedirectToAction("Index", "Home");
        }

        private void SetUserTrackingCookie(string UserId)
        {
            //add uid cookie
            HttpCookie uidCookie = new HttpCookie("uid");
            uidCookie.Value = UserId;
            uidCookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(uidCookie);
        }
    }
}