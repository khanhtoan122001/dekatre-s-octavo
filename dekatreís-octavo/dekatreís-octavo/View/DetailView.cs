using dekatreís_octavo.Bus;
using dekatreís_octavo.Properties;
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
        bool editing = false;
        public TaiKhoan taiKhoan;// DataProvider.Instance.TaiKhoan;
        public DetailView()
        {
            InitializeComponent();
        }

        public void LoadTaiKhoan(TaiKhoan taiKhoan)
        {
            this.taiKhoan = taiKhoan;
            accountLabel.Text = taiKhoan.TenDangNhap;
            nameTextBox.Text = taiKhoan.TenThat;
            phoneTextBox.Text = taiKhoan.SDT;
            idTextBox.Text = taiKhoan.CMND;
            if (taiKhoan.LoaiTaiKhoan1.TenLoai == "admin")
            {
                positionComboBox.SelectedIndex = 0;
            }
            else
            {
                positionComboBox.SelectedIndex = 1;
            }
            if (taiKhoan.Avatar != null)
                avatar.Image = ImageHelper.byteArrayToImage(taiKhoan.Avatar);
            else
                avatar.Image = Resources.default_avatar_300x300;
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                taiKhoan.TenThat = nameTextBox.Text;
                taiKhoan.SDT = phoneTextBox.Text;
                taiKhoan.CMND = idTextBox.Text;
                DataProvider.Instance.db.SaveChanges();
                editing = false;
            }
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

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editing == false)
            {
                nameTextBox.Enabled = true;
                idTextBox.Enabled = true;
                phoneTextBox.Enabled = true;
                positionComboBox.Enabled = true;
                editButton.Text = "Lưu";
                editing = true;
            }
            else
            {
                nameTextBox.Enabled = false;
                idTextBox.Enabled = false;
                phoneTextBox.Enabled = false;
                positionComboBox.Enabled = false;
                taiKhoan.TenThat = nameTextBox.Text;
                taiKhoan.SDT = phoneTextBox.Text;
                taiKhoan.CMND = idTextBox.Text;
                DataProvider.Instance.db.SaveChanges();
                editButton.Text = "Chỉnh sửa";
                editing = false;
            }
        }

        private void DetailView_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void accountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
