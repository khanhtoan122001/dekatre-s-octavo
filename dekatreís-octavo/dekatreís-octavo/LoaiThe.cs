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
    
    public partial class LoaiThe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThe()
        {
            this.BaoCaoDoanhThuThangs = new HashSet<BaoCaoDoanhThuThang>();
            this.TheXes = new HashSet<TheXe>();
        }
    
        public int IDLoai { get; set; }
        public string TenLoai { get; set; }
        public Nullable<int> Gia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoCaoDoanhThuThang> BaoCaoDoanhThuThangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheXe> TheXes { get; set; }
    }
}
