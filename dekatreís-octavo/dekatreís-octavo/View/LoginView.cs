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
using dekatreís_octavo.Bus;


namespace dekatreís_octavo.View
{
    public partial class LoginView : Form
    {
        public TaiKhoan TaiKhoan = DataProvider.Instance.TaiKhoan;
        public LoginView()
        {
            InitializeComponent();
            LoginViewBus.Instance.CheckDataAccount();
        }        

        private void containedButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                return;
            }
            else
            {
                TaiKhoan = LoginViewBus.Instance.Login(tb_Username.Text, tb_Password.Text);
                if (TaiKhoan != null)
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
