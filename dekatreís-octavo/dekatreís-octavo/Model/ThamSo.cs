using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    [Table("ThamSo")]
    public class ThamSo
    {
        public int GiaTri { get; set; }
        public int IDThamSo { get; set; }
        public string TenThamSo { get; set; }
    }
}
