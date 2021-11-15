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
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

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
                return;
            }
            else
            {
                TaiKhoan = LoginViewBus.Instance.Login(tb_Username.Text, tb_Password.Text);
                if (TaiKhoan != null)
                {
                    HomeView home = new HomeView();
                    this.Hide();
                    home.ShowDialog();
                    this.Show();
                }
            }
        }
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
            Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            //materialButton1.BackgroundImage = Image.FromFile(@"C:\Users\ADMIN\OneDrive\Documents\GitHub\dekatre-s-octavo\dekatreís-octavo\dekatreís-octavo\Resources\close.png");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
