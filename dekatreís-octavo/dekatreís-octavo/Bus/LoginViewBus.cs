using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dekatreís_octavo.Bus;

namespace dekatreís_octavo.Bus
{
    public class LoginViewBus
    {
        static LoginViewBus instance;
        public static LoginViewBus Instance { get { if (instance == null) instance = new LoginViewBus(); return instance; } set { instance = value; } }

        QuanLyDoXeEntities db = DataProvider.Instance.db;

        public TaiKhoan Login(string username, string password)
        {
            string pass = DataProvider.Instance.Encrypt(password);
            DataProvider.Instance.TaiKhoan = db.TaiKhoans.Where(p => p.TenDangNhap == username && p.MatKhau == pass).SingleOrDefault();
            return DataProvider.Instance.TaiKhoan;
        }
        public void CheckDataAccount()
        {
            if (db.LoaiTaiKhoans.Count() == 0)
            {
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "admin" });
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "staff" });
                db.SaveChanges();
            }
            if (db.TaiKhoans.Count() == 0)
            {
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "admin", MatKhau = DataProvider.Instance.Encrypt("admin"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "admin").SingleOrDefault().IDLoai });
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "staff", MatKhau = DataProvider.Instance.Encrypt("staff"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "staff").SingleOrDefault().IDLoai });
                db.SaveChanges();
            }
        }
        
    }
}
