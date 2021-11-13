using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dekatreís_octavo.Bus;

namespace dekatreís_octavo.View
{
    public partial class StaffView : UserControl
    {        
        public static TaiKhoan selectedTaiKhoan;
        StaffViewBus staffViewBus = new StaffViewBus();
        public StaffView()
        {
            InitializeComponent();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            //Load from Database
            LoadStaffList();
            //
        }

        private void LoadStaffList()
        {
            materialListView1.Items.Clear();
            List<ListViewItem> itemList = staffViewBus.SelectTaiKhoanListViewItem();
            foreach (var item in itemList)
            {
                materialListView1.Items.Add(item);
            }
            
        }

        private void containedButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                staffViewBus.DeleteTaiKhoan(selectedTaiKhoan);                
                LoadStaffList();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            containedButton2.Enabled = true;
            containedButton3.Enabled = true;
            if (materialListView1.SelectedItems.Count == 0)
                return;
            //Select an account
            selectedTaiKhoan = staffViewBus.SelectTaiKhoan(materialListView1.SelectedItems[0].SubItems[4].Text);
        }

        private void containedButton2_Click(object sender, EventArgs e)
        {
            EditStaffView editStaffForm = new EditStaffView(selectedTaiKhoan);
            if (editStaffForm.ShowDialog() == DialogResult.OK)
                LoadStaffList();            
        }
    }
}
