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
        public ChangePass()
        {
            InitializeComponent();
        }

        private void Confirm_Change_Click(object sender, EventArgs e)
        {
            switch (Bus.ChangePassBus.Instance.ChangePassword(tb_OldPass.Text, tb_NewPass.Text, tb_ConfirmPass.Text))
            {
                case 0:
                    MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                    break;
                case 1:
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                    break;
                case 2:
                    MessageBox.Show("Sai mật khẩu!");
                    break;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
