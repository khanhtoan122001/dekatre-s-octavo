using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dekatreís_octavo.View
{
    public partial class LoginView : Form
    {
        public static QuanLyDoXeEntities db = new QuanLyDoXeEntities();
        public LoginView()
        {
            InitializeComponent();
            CheckDataAccount();
        }
        public string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }

        private void CheckDataAccount()
        {
            if(db.LoaiTaiKhoans.Count() == 0)
            {
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "admin" });
                db.LoaiTaiKhoans.Add(new LoaiTaiKhoan() { TenLoai = "staff" });
                db.SaveChanges();
            }
            if (db.TaiKhoans.Count() == 0)
            {
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "admin", MatKhau = Encrypt("admin"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "admin").SingleOrDefault().IDLoai});
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = "staff", MatKhau = Encrypt("staff"), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "staff").SingleOrDefault().IDLoai });
                db.SaveChanges();
            }

        }

        private void containedButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                return;
            }
            else
            {
                string pass = Encrypt(tb_Password.Text);
                var result = db.TaiKhoans.Where(p => p.TenDangNhap == tb_Username.Text && p.MatKhau == pass).SingleOrDefault();
                if (result != null)
                {
                    HomeView home = new HomeView();
                    home.TaiKhoan = result;
                    home.Show();
                    this.Hide();
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
