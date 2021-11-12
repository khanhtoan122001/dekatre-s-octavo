using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("CT_BaoCaoDoanhThuThang")]
    public class CT_BaoCaoDoanhThuThang
    {
        public int IDCTBaoCao { get; set; }
        public int IDBaoCao { get; set; }
        public int Thang { get; set; }
        public int TongThu { get; set; }
        public int TongChi { get; set; }
        public int ChenhLech { get; set; }
    }
}
