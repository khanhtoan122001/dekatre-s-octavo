using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class BaoCaoDoanhThuThang
    {
        private float iDBaoCao, nam, loaiThe;

        public float IDBaoCao { get => iDBaoCao; set => iDBaoCao = value; }
        public float Nam { get => nam; set => nam = value; }
        public float LoaiThe { get => loaiThe; set => loaiThe = value; }

        public BaoCaoDoanhThuThang() { }
        public BaoCaoDoanhThuThang(DataRow row)
        {
            this.iDBaoCao = Convert.ToSingle(row["IDBaoCao"]);
            this.nam = Convert.ToSingle(row["Nam"]);
            this.loaiThe = Convert.ToSingle(row["LoaiThe"]);
        }
    }
}
