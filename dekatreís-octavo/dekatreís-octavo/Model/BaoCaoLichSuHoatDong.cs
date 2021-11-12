using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("BaoCaoLichSuHoatDong")]
    public class BaoCaoLichSuHoatDong
    {
        public float IDBaoCao { get; set; }
        public float HoatDong { get; set; }
        public DateTime Ngay { get; set; }
    }
}
