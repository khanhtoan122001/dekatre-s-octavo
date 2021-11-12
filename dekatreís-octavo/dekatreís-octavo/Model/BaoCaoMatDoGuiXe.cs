using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace dekatreís_octavo.Model
{
    [Table("BaoCaoMatDoGuiXe")]
    public class BaoCaoMatDoGuiXe
    {
        public int IDBaoCao { get; set; }
        public int Gio { get; set; }
        public int TongXeVao { get; set; }
        public int TongXeRa { get; set; }
        public int ChenhLech { get; set; }
        public DateTime Ngay { get; set; }
    }
}
