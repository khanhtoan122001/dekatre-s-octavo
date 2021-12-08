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
using dekatreís_octavo.Properties;

namespace dekatreís_octavo.View
{
    public partial class HomeView : Form
    {
        TaiKhoan TaiKhoan = DataProvider.Instance.TaiKhoan;
        public HomeView()
        {
            InitializeComponent();
            pictureBox2.Image = LoginViewBus.Instance.byteArrayToImage(TaiKhoan.Avatar);
            //tabPage1.Controls.Add(new CardManagement());
            //tabPage1.BackColor = Color.White;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialCard1.Visible == false)
                materialCard1.Visible = true;
            else materialCard1.Visible = false;
        }

        private void bt_ChangePass_Click(object sender, EventArgs e)
        {
            materialCard1.Visible = false;
            ChangePass changePass = new ChangePass();
            changePass.Show();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.TaiKhoan = null;
            this.Close();
            ////LoginView loginView = new LoginView();
            //loginView.Show();
        }

        private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(DataProvider.Instance.TaiKhoan != null)
                Application.Exit();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            if (DataProvider.Instance.TaiKhoan.Avatar == null)
                LoginViewBus.Instance.ChangeAvatar(Resources.default_avatar_300x300);
            cardManagement1.LoadData();
            staffView1.LoadStaffList();
            parkingView1.LoadData();
            
            BaoCaoChamCongNhanVienBus.Instance.ChamCong();
        }

        private void AddTab()
        {
            tabControl.TabPages.Clear();
            if (TaiKhoan.LoaiTaiKhoan == 1)
            {

            }
        }

        private void Refresh(Point e)
        {
            if (!materialCard1.DisplayRectangle.Contains(e))
            {
                if (materialCard1.Visible == true)
                    materialCard1.Visible = false;
            }
        }

        private void LoadThamSo()
        {
            var listTs = ThamSoBus.Instance.GetThamSos();
            tb_Vethuong.Text = listTs.Where(p => p.TenThamSo == "Thẻ thường").FirstOrDefault().GiaTri.Value.ToString();
            tb_Vethang.Text = listTs.Where(p => p.TenThamSo == "Thẻ tháng").FirstOrDefault().GiaTri.Value.ToString();
            tb_Luong.Text = listTs.Where(p => p.TenThamSo == "Lương").FirstOrDefault().GiaTri.Value.ToString();
            tb_TienMatBang.Text = listTs.Where(p => p.TenThamSo == "Tiền mặt bằng").FirstOrDefault().GiaTri.Value.ToString();
        }

        private void materialDrawer1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh(e.Location);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            Refresh(Control.MousePosition);
            if (e.TabPageIndex == 6)
                LoadThamSo();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value < DateTime.Today)
            {
                dateTimePicker.Value = DateTime.Today;
            }
        }

        private void setting_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            consistenceReport1.Visible = true;
            consistenceReport1.LoadData();
        }


        private void bt_info_Click_1(object sender, EventArgs e)
        {
            DetailView detailView = new DetailView();
            detailView.Show();
        }
    }
}
