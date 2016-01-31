//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPTV2_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseItem
    {
        public int PurchaseItemId { get; set; }
        public int PurchaseId { get; set; }
        public System.Guid RecipientUserId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public int EntitlementRequestId { get; set; }
        public string Remarks { get; set; }
    
        public virtual Purchase Purchase { get; set; }
        public virtual User User { get; set; }
        public virtual EntitlementRequest EntitlementRequest { get; set; }
        public virtual SubscriptionProduct SubscriptionProduct { get; set; }
    }
}
