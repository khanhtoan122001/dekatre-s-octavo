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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialCard1.Visible == false)
                materialCard1.Visible = true;
            else materialCard1.Visible = false;
        }

        private void textButton1_Click(object sender, EventArgs e)
        {

        }

        private void textButton2_Click(object sender, EventArgs e)
        {
            ChangePass changePass = new ChangePass();
            changePass.Show();
        }

        private void textButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginView loginView = new LoginView();
            loginView.Show();
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
