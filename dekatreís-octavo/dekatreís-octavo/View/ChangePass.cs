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
    public partial class ChangePass : Form
    {
        TaiKhoan TaiKhoan = LoginView.TaiKhoan;
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Confirm_Change_Click(object sender, EventArgs e)
        {
            if(Encrypt.EncryptString(tb_OldPass.Text) == TaiKhoan.MatKhau)
            {
                if(tb_NewPass.Text == tb_ConfirmPass.Text)
                {
                    TaiKhoan.MatKhau = Encrypt.EncryptString(tb_NewPass.Text);
                    LoginView.db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!");
            }
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
