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
    
    public partial class TaiKhoan
    {
        public int IDTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenThat { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public Nullable<int> LoaiTaiKhoan { get; set; }
    
        public virtual LoaiTaiKhoan LoaiTaiKhoan1 { get; set; }
    }
}
