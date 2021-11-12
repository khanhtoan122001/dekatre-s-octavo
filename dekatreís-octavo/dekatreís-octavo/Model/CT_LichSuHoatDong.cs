using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("CT_LichSuHoatDong")]
    public class CT_LichSuHoatDong
    {
        public int IDCTBaoCao { get; set; }
        public int IDBaoCao { get; set; }
        public DateTime ThoiGian { get; set; }
    }
}
