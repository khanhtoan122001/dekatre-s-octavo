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
    
    public partial class CT_BaoCaoLichSuHoatDong
    {
        public int IDCTBaoCao { get; set; }
        public int IDBaoCao { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public string BienSo { get; set; }
    
        public virtual BaoCaoLichSuHoatDong BaoCaoLichSuHoatDong { get; set; }
    }
}
