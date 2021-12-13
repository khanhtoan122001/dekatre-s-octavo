using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dekatreís_octavo.Bus;
using ListViewSortAnyColumn;

namespace dekatreís_octavo.View
{
    public partial class StaffView : UserControl
    {        
        public TaiKhoan selectedTaiKhoan;
        
        public StaffView()
        {
            InitializeComponent();
        }

        private void StaffView_Load(object sender, EventArgs e)
        {
            //Load from Database
            //LoadStaffList();
            //
        }

        public void LoadStaffList(List<TaiKhoan> list = null)
        {
            materialListView1.Items.Clear();
            List<ListViewItem> itemList = StaffViewBus.Instance.SelectTaiKhoanListViewItem(list);
            foreach (var item in itemList)
            {
                materialListView1.Items.Add(item);
            }
            
        }

        private void containedButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StaffViewBus.Instance.DeleteTaiKhoan(selectedTaiKhoan);                
                LoadStaffList();
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
                return;
            //Select an account
            passResetButton.Enabled = true;
            //bt_edit.Enabled = true;
            bt_remove.Enabled = true;
            selectedTaiKhoan = StaffViewBus.Instance.SelectTaiKhoan(materialListView1.SelectedItems[0].SubItems[4].Text);
        }

        private void containedButton2_Click(object sender, EventArgs e)
        {
            EditStaffView editStaffForm = new EditStaffView(selectedTaiKhoan);
            if (editStaffForm.ShowDialog() == DialogResult.OK)
                LoadStaffList();
            editStaffForm.Dispose();
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            AddStaffView addStaffView = new AddStaffView();
            if (addStaffView.ShowDialog() == DialogResult.OK)
                LoadStaffList();
            addStaffView.Dispose();
        }

        private void materialListView1_DoubleClick(object sender, EventArgs e)
        {
            containedButton2_Click(null, null);
        }

        private void passResetButton_Click(object sender, EventArgs e)
        {
            selectedTaiKhoan.MatKhau = DataProvider.Instance.Encrypt("123456");
            MessageBox.Show("Đã đặt về mật khẩu mặc định: 123456");
            DataProvider.Instance.db.SaveChanges();
        }

        private void materialTextfield1_TextChanged(object sender, EventArgs e)
        {
            LoadStaffList(StaffViewBus.Instance.Search(materialTextfield1.Text, cb_typeSearch.SelectedIndex));
        }
        private void listViewSample_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = materialListView1.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                materialListView1.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            materialListView1.Sort();
        }
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void materialListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DetailView detail = new DetailView();
            detail.LoadTaiKhoan(selectedTaiKhoan);
            detail.ShowDialog();
            LoadStaffList();
        }
    }
}
