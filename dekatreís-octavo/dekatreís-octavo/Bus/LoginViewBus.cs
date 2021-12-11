using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using dekatreís_octavo.Bus;
using System.IO;

namespace dekatreís_octavo.Bus
{
    public class LoginViewBus
    {
        static LoginViewBus instance;
        public static LoginViewBus Instance { get { if (instance == null) instance = new LoginViewBus(); return instance; } set { instance = value; } }

        QuanLyDoXeEntities1 db = DataProvider.Instance.db;

        public TaiKhoan Login(string username, string password)
        {
            string pass = DataProvider.Instance.Encrypt(password);
            DataProvider.Instance.TaiKhoan = db.TaiKhoans.Where(p => p.TenDangNhap == username && p.MatKhau == pass).SingleOrDefault();
            return DataProvider.Instance.TaiKhoan;
        }
        public void CheckDataAccount()
        {
            if (db.LoaiTaiKhoans.Count(p => true) == 0)
            {
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "admin" });
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "staff" });
                db.SaveChanges();
            }
            if (db.TaiKhoans.Count(p => true) == 0)
            {
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "admin", MatKhau = DataProvider.Instance.Encrypt("admin"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "admin").SingleOrDefault().IDLoai });
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "staff", MatKhau = DataProvider.Instance.Encrypt("staff"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "staff").SingleOrDefault().IDLoai });
                db.SaveChanges();
            }
        }

        public bool ChangeAvatar(Image image)
        {
            if (DataProvider.Instance.TaiKhoan != null)
            {
                DataProvider.Instance.TaiKhoan.Avatar = ImageHelper.imageToByteArray(image);
                DataProvider.Instance.db.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool SaveChange(TaiKhoan tk)
        {
            if (DataProvider.Instance.TaiKhoan != null)
            {
                DataProvider.Instance.TaiKhoan.CMND = tk.CMND;
                DataProvider.Instance.TaiKhoan.SDT = tk.SDT;
                DataProvider.Instance.TaiKhoan.TenThat = tk.TenThat;
                DataProvider.Instance.db.SaveChanges();
                return true;
            }
            else return false;
        }
        
        
    }
}
