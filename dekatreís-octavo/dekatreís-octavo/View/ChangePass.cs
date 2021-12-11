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
            tb_OldPass.Focus();
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
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        private void lblMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Release the mouse capture started by the mouse down.
                this.Capture = false;

                // Create and send a WM_NCLBUTTONDOWN message.
                const int WM_NCLBUTTONDOWN = 0x00A1;
                const int HTCAPTION = 2;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_OldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                tb_NewPass.Focus();
        }

        private void tb_NewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                tb_ConfirmPass.Focus();
        }

        private void tb_ConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Confirm_Change_Click(sender, e);
        }
    }
}
