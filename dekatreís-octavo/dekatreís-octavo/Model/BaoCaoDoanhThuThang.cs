using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("BaoCaoDoanhThuThang")]
    public class BaoCaoDoanhThuThang
    { 
        public int IDBaoCao { get; set; }
        public int Nam { get; set; }
        public int LoaiThe { get; set; }
    }
}
