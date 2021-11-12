using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace dekatreís_octavo.Model
{
    public class BaoCaoMatDoGuiXe
    {
        private float iDBaoCao, gio, tongXeVao, tongXeRa, chenhLech;
        private DateTime ngay;

        public float IDBaoCao { get => iDBaoCao; set => iDBaoCao = value; }
        public float Gio { get => gio; set => gio = value; }
        public float TongXeVao { get => tongXeVao; set => tongXeVao = value; }
        public float TongXeRa { get => tongXeRa; set => tongXeRa = value; }
        public float ChenhLech { get => chenhLech; set => chenhLech = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }

        public BaoCaoMatDoGuiXe() { }

        public BaoCaoMatDoGuiXe(DataRow row)
        {
            this.iDBaoCao = Convert.ToSingle(row["IDBaoCao"]);
            this.gio = Convert.ToSingle(row["Gio"]);
            this.tongXeVao = Convert.ToSingle(row["TongXeVao"]);
            this.tongXeRa = Convert.ToSingle(row["TongXeRa"]);
            this.chenhLech = Convert.ToSingle(row["ChenhLech"]);
            this.ngay = Convert.ToDateTime(row["Ngay"]);
        }
    }
}
