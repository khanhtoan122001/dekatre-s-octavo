using dekatreís_octavo.Bus;
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
        public TaiKhoan taiKhoan = DataProvider.Instance.TaiKhoan;
        public DetailView()
        {
            InitializeComponent();
            accountLabel.Text = taiKhoan.TenDangNhap;
            nameLabel.Text = taiKhoan.TenThat;
            phoneLabel.Text = taiKhoan.SDT;
            idLabel.Text = taiKhoan.CMND;
            avatar.Image = LoginViewBus.Instance.byteArrayToImage(taiKhoan.Avatar);
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cirPictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "";
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image files (*.jpg)|*.jpg|(*.jpeg)|*jpeg|(*.bmp)|*.bmp|(*wmf)|*wmf|(*.png)|*.png|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                avatar.Image = new Bitmap(openFileDialog.FileName);
                LoginViewBus.Instance.ChangeAvatar(avatar.Image);
            }    
        }
    }
}
