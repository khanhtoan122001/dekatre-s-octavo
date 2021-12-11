using MaterialSurface;
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
        

        public TaiKhoan TaiKhoan;
        public LoginView()
        {
            InitializeComponent();
            DataProvider.Instance.CreateDataDefault();
        }        

        private void containedButton1_Click(object sender, EventArgs e)
        {
                
            if (string.IsNullOrEmpty(tb_Username.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                Dialog.Show(this, "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Đăng nhập thất bại");
                return;
            }
            else
            {
                TaiKhoan = LoginViewBus.Instance.Login(tb_Username.Text, tb_Password.Text);
                if (TaiKhoan != null)
                {
                    HomeView home = new HomeView();
                    home.Show();
                    this.Close();
                }
                else
                {
                    Dialog.Show(this, "Sai tên đăng nhập hoặc mật khẩu, vui lòng kiểm tra lại!", "Đăng nhập thất bại");
                }
            }
        }
        #region Di chuyen
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
        #endregion
        private void materialButton1_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            //materialButton1.BackgroundImage = Image.FromFile(@"C:\Users\ADMIN\OneDrive\Documents\GitHub\dekatre-s-octavo\dekatreís-octavo\dekatreís-octavo\Resources\close.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Dialog.Show(this, "Bạn chắc chắn muốn thoát?", "Xác nhận", Buttons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }

        private void tb_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tb_Password.Focus();
            }
        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.containedButton1_Click(null, null);
            }
        }

        private void LoginView_Resize(object sender, EventArgs e)
        {
            this.Size = new Size(953, 550);
        }
    }
}
