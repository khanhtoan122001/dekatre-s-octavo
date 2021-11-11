using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class BaoCaoLichSuHoatDong
    {
        private float iDBaoCao, hoatDong;
        private DateTime ngay;

        public float IDBaoCao { get => iDBaoCao; set => iDBaoCao = value; }
        public float HoatDong { get => hoatDong; set => hoatDong = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }

        public BaoCaoLichSuHoatDong() { }

        public BaoCaoLichSuHoatDong(DataRow row)
        {
            this.iDBaoCao = Convert.ToSingle(row["IDBaoCao"]);
            this.hoatDong = Convert.ToSingle(row["HoatDong"]);
            this.ngay = Convert.ToDateTime(row["Ngay"]);
        }
    }
}
