using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dekatreís_octavo.Model
{
    public class TaiKhoan
    {
        private float iDTaiKhoan, loaiTaiKhoan;
        private string tenDangNhap, matKhau, tenThat, sDT, cMND;

        public float IDTaiKhoan { get => iDTaiKhoan; set => iDTaiKhoan = value; }
        public float LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TenThat { get => tenThat; set => tenThat = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CMND { get => cMND; set => cMND = value; }

        public TaiKhoan() { }

        public TaiKhoan(DataRow row)
        {
            this.iDTaiKhoan = Convert.ToSingle(row["IDTaiKhoan"]);
            this.loaiTaiKhoan = Convert.ToSingle(row["LoaiTaiKhoan"]);
            this.tenDangNhap = Convert.ToString(row["TenDangNhap"]);
            this.matKhau = Convert.ToString(row["MatKhau"]);
            this.tenThat = Convert.ToString(row["TenThat"]);
            this.sDT = Convert.ToString(row["SDT"]);
            this.cMND = Convert.ToString(row["CMND"]);
        }
    }
}
