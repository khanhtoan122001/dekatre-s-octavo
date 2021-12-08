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
        bool editing = false;
        public TaiKhoan taiKhoan = DataProvider.Instance.TaiKhoan;
        public DetailView()
        {
            InitializeComponent();
            accountLabel.Text = taiKhoan.TenDangNhap;
            nameTextBox.Text = taiKhoan.TenThat;
            phoneTextBox.Text = taiKhoan.SDT;
            idTextBox.Text = taiKhoan.CMND;
            if (taiKhoan.LoaiTaiKhoan1.TenLoai == "admin")
            {
                positionTextBox.Text = "admin";
            }
            else
            {
                positionTextBox.Text = "staff";
            }
            avatar.Image = LoginViewBus.Instance.byteArrayToImage(taiKhoan.Avatar);
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenThat = nameTextBox.Text;
                tk.SDT = phoneTextBox.Text;
                tk.CMND = idTextBox.Text;
                LoginViewBus.Instance.SaveChange(tk);
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
                editButton.Text = "Save";
                closeButton.Text = "Save & exit";
                editing = true;
            }
            else
            {
                nameTextBox.Enabled = false;
                idTextBox.Enabled = false;
                phoneTextBox.Enabled = false;
                TaiKhoan tk = new TaiKhoan();
                tk.TenThat = nameTextBox.Text;
                tk.SDT = phoneTextBox.Text;
                tk.CMND = idTextBox.Text;
                LoginViewBus.Instance.SaveChange(tk);
                editButton.Text = "Edit";
                closeButton.Text = "Close";
                editing = false;
            }
        }

        private void DetailView_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
