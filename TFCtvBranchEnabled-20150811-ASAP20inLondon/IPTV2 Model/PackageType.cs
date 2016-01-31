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
    
    public abstract partial class PackageType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PackageType()
        {
            this.Categories = new HashSet<PackageCategory>();
            this.Channels = new HashSet<PackageChannel>();
            this.Carousels = new HashSet<PackageCarousel>();
            this.Products = new HashSet<ProductPackage>();
            this.AuditTrail = new AuditTrail();
        }
    
        public int PackageId { get; set; }
        public string PackageName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public byte StatusId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Weekly { get; set; }
        public Nullable<int> Daily { get; set; }
        public Nullable<int> Special { get; set; }
        public int OfferingId { get; set; }
    
        public AuditTrail AuditTrail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageCategory> Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageChannel> Channels { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageCarousel> Carousels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPackage> Products { get; set; }
    }
}
