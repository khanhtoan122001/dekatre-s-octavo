using dekatreís_octavo.Bus;
using System;
using MaterialSurface;
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
    public partial class HomeView : Form
    {
        TaiKhoan TaiKhoan = DataProvider.Instance.TaiKhoan;
        public HomeView()
        {
            InitializeComponent();
           
            //tabPage1.Controls.Add(new CardManagement());
            //tabPage1.BackColor = Color.White;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialCard1.Visible == false)
                materialCard1.Visible = true;
            else materialCard1.Visible = false;
        }

        private void bt_info_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_ChangePass_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.Show();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            cardManagement1.LoadData();
        }

        private void AddTab()
        {
            tabControl.TabPages.Clear();
            if (TaiKhoan.LoaiTaiKhoan == 1)
            {

            }
        }

        private void cardManagement1_Load(object sender, EventArgs e)
        {

        }
    }
}
