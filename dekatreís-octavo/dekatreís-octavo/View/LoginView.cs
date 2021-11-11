using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekatreís_octavo
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            HomeView homeView = new HomeView();
            homeView.Show();
            this.Hide();
        }
    }
}
