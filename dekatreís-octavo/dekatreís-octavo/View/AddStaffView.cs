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
    public partial class AddStaffView : Form
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        public AddStaffView()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string error = "";
            if (materialTextBox1.Text == "" || materialTextBox2.Text == "")
                error += "Tên và tên đăng nhập không được bỏ trống\n";
            if (materialTextfield1.Text != materialTextfield2.Text)
                error += "Mật khẩu không trùng khớp\n";
            if (error != "")
                MessageBox.Show(error);
            else
            {
                TaiKhoan result = db.TaiKhoans.Where((p) => p.TenDangNhap == materialTextBox2.Text).FirstOrDefault();
                if (result == null)
                {
                    db.TaiKhoans.Add(new TaiKhoan() { TenThat = materialTextBox1.Text ,TenDangNhap = materialTextBox2.Text, MatKhau = DataProvider.Instance.Encrypt(materialTextfield1.Text), LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "staff").SingleOrDefault().IDLoai });
                    db.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
            }
        }
    }
}
