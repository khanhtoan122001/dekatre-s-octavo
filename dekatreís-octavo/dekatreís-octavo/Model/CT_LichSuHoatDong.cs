using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class CT_LichSuHoatDong
    {
        private float iDCTBaoCao, iDBaoCao;
        DateTime thoiGian;

        public float IDCTBaoCao { get => iDCTBaoCao; set => iDCTBaoCao = value; }
        public float IDBaoCao { get => iDBaoCao; set => iDBaoCao = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public CT_LichSuHoatDong() { }

        public CT_LichSuHoatDong(DataRow row)
        {
            this.iDCTBaoCao = Convert.ToSingle("IDCTBaoCao");
            this.iDBaoCao = Convert.ToSingle("IDBaoCao");
            this.thoiGian = Convert.ToDateTime("ThoiGian");
        }
    }
}
