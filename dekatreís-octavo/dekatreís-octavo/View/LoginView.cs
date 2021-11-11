using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace dekatreís_octavo.View
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            DataAccess.LoaiTaiKhoan.Instance.CheckLoaiTaiKhoan();
            DataAccess.Account.Instance.CheckAccount();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_TenDangNhap.Text) || string.IsNullOrEmpty(tb_MatKhau.Text))
            {
                return;
            }
            else
            {
                if(DataAccess.Account.Instance.Login(tb_TenDangNhap.Text, tb_MatKhau.Text))
                {
                    HomeView home = new HomeView();
                    home.taiKhoan = new Model.TaiKhoan(DataAccess.Account.Instance.GetInfoAcc(tb_TenDangNhap.Text));
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai");
                }
            }
        }
    }
}
