using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("TheXe")]
    public class TheXe
    {
        public int IDThe { get; set; }
        public int LoaiThe { get; set; }
        public string ChuSoHuu { get; set; }
        public string TenXe { get; set; }
        public string BienSoXe { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime ThoiGianGui { get; set; }
    }
}
