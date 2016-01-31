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
    
    public partial class ChannelCdn
    {
        public int ChannelId { get; set; }
        public int CdnId { get; set; }
        public string CdnReference { get; set; }
        public string CdnContentId { get; set; }
        public Nullable<int> Priority { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.Guid> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<System.Guid> UpdatedBy { get; set; }
    
        public virtual CDN CDN { get; set; }
        public virtual Channel Channel { get; set; }
    }
}
