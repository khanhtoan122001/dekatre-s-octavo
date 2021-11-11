using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class LoaiTaiKhoan
    {
        private float iDLoai;
        private string tenLoai;

        public float IDLoai { get => iDLoai; set => iDLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }

        public LoaiTaiKhoan() { }

        public LoaiTaiKhoan(DataRow row)
        {
            this.iDLoai = Convert.ToSingle(row["IDLoai"]);
            this.tenLoai = row["TenLoai"].ToString();
        }
    }
}
