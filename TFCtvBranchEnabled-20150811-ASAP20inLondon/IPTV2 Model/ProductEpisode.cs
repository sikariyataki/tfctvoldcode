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
    
    public partial class ProductEpisode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductEpisode()
        {
            this.AuditTrail = new AuditTrail();
        }
    
        public int ProductId { get; set; }
        public int EpisodeId { get; set; }
    
        public AuditTrail AuditTrail { get; set; }
    
        public virtual EpisodeSubscriptionProduct Product { get; set; }
        public virtual Episode Episode { get; set; }
    }
}
