using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("LoaiTaiKhoan")]
    public class LoaiTaiKhoan
    {
        public int IDLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
