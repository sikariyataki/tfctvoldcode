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
    
    public partial class ShowFeatureItem : FeatureItem
    {
        public int CategoryId { get; set; }
    
        public virtual Show Show { get; set; }
    }
}
