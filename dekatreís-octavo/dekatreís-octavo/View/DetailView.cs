﻿using dekatreís_octavo.Bus;
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
    public partial class DetailView : Form
    {
        public TaiKhoan TaiKhoan;
        public DetailView()
        {
            InitializeComponent();
            accountLabel.Text = TaiKhoan.TenDangNhap;
            nameLabel.Text = TaiKhoan.TenThat;
            phoneLabel.Text = TaiKhoan.SDT;
            idLabel.Text = TaiKhoan.CMND;
            avatar = LoginViewBus.Instance.byteArrayToImage(TaiKhoan.Avatar);
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
