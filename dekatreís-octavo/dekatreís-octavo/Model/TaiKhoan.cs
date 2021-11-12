using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        public int IDTaiKhoan { get; set; }
        public int LoaiTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenThat { get; set; }
        public string SDT { get; set; }
    }
}
