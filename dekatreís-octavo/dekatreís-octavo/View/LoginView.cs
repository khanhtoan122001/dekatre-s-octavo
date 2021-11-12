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

        private void containedButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(materialTextfield1.Text) || string.IsNullOrEmpty(materialTextfield2.Text))
            {
                return;
            }
            else
            {
                var result = db.TaiKhoans.Where(p => p.TenDangNhap == materialTextfield1.Text && p.MatKhau == Encrypt(materialTextfield2.Text));
                if (result != null)
                {
                    HomeView home = new HomeView();
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
