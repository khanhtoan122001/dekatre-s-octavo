using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class CT_BaoCaoDoanhThuThang
    {
        private float iDCTBaoCao, iDBaoCao, thang, tongThu, tongChi, chenhLech;

        public float IDCTBaoCao { get => iDCTBaoCao; set => iDCTBaoCao = value; }
        public float IDBaoCao { get => iDBaoCao; set => iDBaoCao = value; }
        public float Thang { get => thang; set => thang = value; }
        public float TongThu { get => tongThu; set => tongThu = value; }
        public float TongChi { get => tongChi; set => tongChi = value; }
        public float ChenhLech { get => chenhLech; set => chenhLech = value; }

        public CT_BaoCaoDoanhThuThang() { }

        public CT_BaoCaoDoanhThuThang(DataRow row)
        {
            this.iDBaoCao = Convert.ToSingle(row["IDBaoCao"]);
            this.iDCTBaoCao = Convert.ToSingle(row["IDCTBaoCao"]);
            this.thang = Convert.ToSingle(row["Thang"]);
            this.tongChi = Convert.ToSingle(row["TongChi"]);
            this.tongThu = Convert.ToSingle(row["TongThu"]);
            this.chenhLech = Convert.ToSingle(row["ChenhLech"]);
        }
    }
}
