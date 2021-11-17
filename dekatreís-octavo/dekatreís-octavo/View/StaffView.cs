﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dekatreís_octavo.Bus;

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

        public void LoadStaffList()
        {
            materialListView1.Items.Clear();
            List<ListViewItem> itemList = StaffViewBus.Instance.SelectTaiKhoanListViewItem();
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
            containedButton2.Enabled = true;
            containedButton3.Enabled = true;
            if (materialListView1.SelectedItems.Count == 0)
                return;
            //Select an account
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
    }
}
