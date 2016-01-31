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
    
    public partial class UserWallet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserWallet()
        {
            this.WalletPaymentTransactions = new HashSet<WalletPaymentTransaction>();
            this.ReloadTransactions = new HashSet<ReloadTransaction>();
        }
    
        public int WalletId { get; set; }
        public System.Guid UserId { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public Nullable<int> GomsWalletId { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WalletPaymentTransaction> WalletPaymentTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReloadTransaction> ReloadTransactions { get; set; }
        public virtual Currency WalletCurrency { get; set; }
    }
}