//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dekatreís_octavo
{
    using System;
    using System.Collections.Generic;
    
    public partial class BaoCaoTongThu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaoCaoTongThu()
        {
            this.CT_BaoCaoTongThu = new HashSet<CT_BaoCaoTongThu>();
        }
    
        public int IDBaoCaoThu { get; set; }
        public Nullable<int> Thang { get; set; }
        public Nullable<int> Nam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BaoCaoTongThu> CT_BaoCaoTongThu { get; set; }
    }
}
