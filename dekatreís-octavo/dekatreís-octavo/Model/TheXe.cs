using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class TheXe
    {
        private float iDThe, loaiThe;
        private string chuSoHuu, tenXe, bienSoXe;
        private DateTime ngayTao, thoiGianGui;

        public float IDThe { get => iDThe; set => iDThe = value; }
        public float LoaiThe { get => loaiThe; set => loaiThe = value; }
        public string ChuSoHuu { get => chuSoHuu; set => chuSoHuu = value; }
        public string TenXe { get => tenXe; set => tenXe = value; }
        public string BienSoXe { get => bienSoXe; set => bienSoXe = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
        public DateTime ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }

        public TheXe() { }

        public TheXe(DataRow row)
        {
            this.iDThe = Convert.ToSingle(row["IDThe"]);
            this.loaiThe = Convert.ToSingle(row["LoaiThe"]);
            this.chuSoHuu = Convert.ToString(row["ChuSoHuu"]);
            this.tenXe = Convert.ToString(row["TenXe"]);
            this.bienSoXe = Convert.ToString(row["BienSoXe"]);
            this.ngayTao = Convert.ToDateTime(row["NgayTao"]);
            this.thoiGianGui = Convert.ToDateTime(row["ThoiGianGui"]);
        }
    }
}
