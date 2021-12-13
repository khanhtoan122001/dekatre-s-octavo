using dekatreís_octavo.Bus;
using MaterialSurface;
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
    public partial class EditStaffView : Form
    {
        private static QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        private TaiKhoan selectedTaiKhoan;
        public EditStaffView(TaiKhoan selectedTaiKhoan)
        {
            this.selectedTaiKhoan = selectedTaiKhoan;
            InitializeComponent();
        }

        private void EditStaff_Load(object sender, EventArgs e)
        {
            materialTextBox1.Text = selectedTaiKhoan.TenThat;
            materialTextBox2.Text = selectedTaiKhoan.CMND;
            materialTextBox3.Text = selectedTaiKhoan.SDT;
            materialTextBox4.Text = selectedTaiKhoan.TenDangNhap;
            if (selectedTaiKhoan.LoaiTaiKhoan == 1)
                materialComboBox1.SelectedIndex = materialComboBox1.FindStringExact("Admin");
            else
                materialComboBox1.SelectedIndex = materialComboBox1.FindStringExact("Nhân Viên");
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = db.TaiKhoans.Where((p) => p.TenDangNhap == selectedTaiKhoan.TenDangNhap).FirstOrDefault();
            taiKhoan.TenThat = materialTextBox1.Text;
            taiKhoan.CMND = materialTextBox2.Text;
            taiKhoan.SDT = materialTextBox3.Text;
            if (materialComboBox1.SelectedIndex == materialComboBox1.FindStringExact("Admin"))
                taiKhoan.LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "admin").FirstOrDefault().IDLoai;
            else
                taiKhoan.LoaiTaiKhoan = db.LoaiTaiKhoans.Where(p => p.TenLoai == "staff").FirstOrDefault().IDLoai;
            db.SaveChanges();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool HasBeenChanged()
        {
            if (!(materialTextBox1.Text == selectedTaiKhoan.TenThat) || !(materialTextBox2.Text == selectedTaiKhoan.CMND) || !(materialTextBox3.Text == selectedTaiKhoan.SDT) || !(materialComboBox1.SelectedIndex == materialComboBox1.FindStringExact("Admin")))
                return true;
            return false;
        }

        private void containedButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
