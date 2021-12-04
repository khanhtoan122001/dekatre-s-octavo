﻿using dekatreís_octavo.Bus;
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
            LoginViewBus.Instance.ChangeAvatar(Resources._59c80c4b45d2a027e83b578f);
            cardManagement1.LoadData();
            staffView1.LoadStaffList();
            parkingView1.LoadData();
            if(DataProvider.Instance.TaiKhoan != null)
                if(DataProvider.Instance.TaiKhoan.Avatar != null)
                {
                    pictureBox1.Image = LoginViewBus.Instance.byteArrayToImage(DataProvider.Instance.TaiKhoan.Avatar);
                }
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

        private void materialDrawer1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh(e.Location);
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            Refresh(Control.MousePosition);
        }
    }
}
