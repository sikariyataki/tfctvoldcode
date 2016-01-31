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
    
    public partial class Episode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Episode()
        {
            this.EpisodeCategories = new HashSet<EpisodeCategory>();
            this.FreeAssets = new HashSet<EpisodeFreeAsset>();
            this.PremiumAssets = new HashSet<EpisodePremiumAsset>();
            this.PreviewAssets = new HashSet<EpisodePreviewAsset>();
            this.AllAssets = new HashSet<EpisodeAsset>();
            this.CelebrityRoles = new HashSet<EpisodeCelebrityRole>();
            this.Products = new HashSet<ProductEpisode>();
            this.EpisodeEntitlements = new HashSet<EpisodeEntitlement>();
            this.EpisodeFeatureItems = new HashSet<EpisodeFeatureItem>();
            this.AuditTrail = new AuditTrail();
            this.ImageAssets = new ImageAssets();
        }
    
        public int EpisodeId { get; set; }
        public string EpisodeCode { get; set; }
        public string EpisodeName { get; set; }
        public string Description { get; set; }
        public string Synopsis { get; set; }
        public string Metadata { get; set; }
        public Nullable<int> EpisodeLength { get; set; }
        public Nullable<System.DateTime> DateAired { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public byte StatusId { get; set; }
        public string LiveChannel { get; set; }
        public Nullable<bool> IsLiveChannelActive { get; set; }
        public string DrmAssetId { get; set; }
        public string OssContentId { get; set; }
        public Nullable<int> EpisodeNumber { get; set; }
        public string Rating { get; set; }
        public int OnlineStatusId { get; set; }
        public int MobileStatusId { get; set; }
        public Nullable<System.DateTime> OnlineStartDate { get; set; }
        public Nullable<System.DateTime> OnlineEndDate { get; set; }
        public Nullable<System.DateTime> MobileStartDate { get; set; }
        public Nullable<System.DateTime> MobileEndDate { get; set; }
        public int Iptv3StatusId { get; set; }
        public Nullable<System.DateTime> Iptv3StartDate { get; set; }
        public Nullable<System.DateTime> Iptv3EndDate { get; set; }
        public string ImageSocialNetwork { get; set; }
    
        public AuditTrail AuditTrail { get; set; }
        public ImageAssets ImageAssets { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeCategory> EpisodeCategories { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeFreeAsset> FreeAssets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodePremiumAsset> PremiumAssets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodePreviewAsset> PreviewAssets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeAsset> AllAssets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeCelebrityRole> CelebrityRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductEpisode> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeEntitlement> EpisodeEntitlements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EpisodeFeatureItem> EpisodeFeatureItems { get; set; }
    }
}
