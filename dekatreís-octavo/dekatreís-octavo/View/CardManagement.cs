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
    public partial class CardManagement : UserControl
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        string sortType, sortStatus;
        bool flag = true;
        public CardManagement()
        {
            InitializeComponent();
        }

        private void CardManagement_Load(object sender, EventArgs e)
        {
            //this.LoadData();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addCard = new AddCardForm();
            addCard.ShowDialog();
            this.LoadData();
        }

        public void LoadData(List<TheXe> thes = null)
        {
            cardList.Items.Clear();
            typeComboBox.Items.Clear();
            List<TheXe> result;
            if(thes != null)
                result = thes;
            else
                result = CardManagementBus.Instance.GetTheXes(sortType, sortStatus).ToList();
            foreach (TheXe i in result)
            {
                string trangthai = (bool)i.Status ? "Rảnh" : "Bận";
                string date = i.LoaiThe1.TenLoai == "Thẻ tháng" ? i.NgayTao.Value.Date.ToString() : "";
        
                cardList.Items.Add(new ListViewItem(
                    new string[] { i.IDThe.ToString(), i.BienSoXe, i.LoaiThe1.TenLoai, trangthai, i.ThoiGianGui.ToString(), i.NgayTao.ToString() })
                { Tag = i });
            }
            List<string> list = db.LoaiThes.Select(p => p.TenLoai).ToList();
            typeComboBox.Items.Add("All");
            foreach (string i in list)
            {
                typeComboBox.Items.Add(i);
            }
            if (flag)
            {
                flag = false;
                if (DataProvider.Instance.TaiKhoan.LoaiTaiKhoan1.TenLoai == "staff")
                {
                    addButton.Enabled = false;
                    delButton.Enabled = false;
                }
            }
        }

        public int GetIDTheXeSelected()
        {
            if (cardList.SelectedItems.Count == 0)
                return -1;
            int idCard = Convert.ToInt32(cardList.SelectedItems[0].Text);
            return idCard;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if(GetIDTheXeSelected() != -1)
            {
                CardManagementBus.Instance.DeleteCard(GetIDTheXeSelected());
                MessageBox.Show("Xóa thẻ thành công");
                this.LoadData();
            }
            
        }

        private void cardList_DoubleClick(object sender, EventArgs e)
        {
            EditCard edit = new EditCard();
            edit.selected = GetIDTheXeSelected();
            edit.ShowDialog();
            this.LoadData();
        }

        private void cardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cardList.SelectedItems.Count == 0)
            {
                inOutButton.Enabled = false;
                createButton.Enabled = false;
            }
            else
            {
                TheXe the = (TheXe)cardList.SelectedItems[0].Tag;
                if (the.LoaiThe1.TenLoai != "Thẻ tháng")
                {
                    inOutButton.Enabled = true;
                    createButton.Enabled = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(the.BienSoXe))
                    {
                        createButton.Enabled = true;
                        inOutButton.Enabled = false;
                    }
                    else
                    {
                        inOutButton.Enabled = true;
                        createButton.Enabled = false;
                    }
                }
                if (the.Status.Value)
                {
                    inOutButton.Text = "Gửi";
                }
                else
                {
                    inOutButton.Text = "Trả";
                }
            }
            if (DataProvider.Instance.TaiKhoan.LoaiTaiKhoan1.TenLoai == "admin")
                inOutButton.Enabled = false;
            
        }

        private void inOutButton_Click(object sender, EventArgs e)
        {
            if (cardList.SelectedItems.Count == 0)
                return;
            TheXe the = (TheXe)cardList.SelectedItems[0].Tag;
            if(the.LoaiThe1.TenLoai != "Thẻ tháng")
            {
                if (!the.Status.Value)
                {
                    GuiNhan(the);
                }
                else
                {
                    inputCard.Left = 267;
                    inputCard.Visible = true;
                    inputTextBox.Focus();
                }
            }
            else
            {
                GuiNhan(the);
            }
        }

        public void GuiNhan(TheXe the, string bienSo = null)
        {
            if (the.Status == null || the.Status == false)
            {
                if (the.LoaiThe1.TenLoai == "Thẻ thường")
                    GuiNhanXeBus.Instance.NhanXeThuong(the.IDThe);
                else
                    GuiNhanXeBus.Instance.NhanXeTheThang(the.IDThe);
            }
            else
            {
                if (the.LoaiThe1.TenLoai == "Thẻ thường")
                    GuiNhanXeBus.Instance.GuiXeThuong(the.IDThe, bienSo, "");
                else
                    GuiNhanXeBus.Instance.GuiXeTheThang(the.IDThe);
            }
            db.SaveChanges();
            this.LoadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            inputCard.Visible = false;
        }

        private void inputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TheXe the = (TheXe)cardList.SelectedItems[0].Tag;
            if(e.KeyCode == Keys.Enter)
            {
                this.pictureBox2_Click(null, null);
                //GuiNhan(the, inputTextBox.Text);
                //inputCard.Visible = false;
            }
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            inputCard.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TheXe the = (TheXe)cardList.SelectedItems[0].Tag;
            if (!string.IsNullOrEmpty(inputTextBox.Text))
            {
                if (the.LoaiThe1.TenLoai == "Thẻ tháng" && string.IsNullOrEmpty(the.BienSoXe))
                {
                    CardManagementBus.Instance.DangKyTheThang(the.IDThe, inputTextBox.Text);
                    LoadData();
                }
                else
                {
                    GuiNhan(the, inputTextBox.Text);
                }
            }
            inputTextBox.Text = "";
            inputCard.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            inputCard.Left = 267;
            inputCard.Visible = true;
            inputTextBox.Focus();
        }

        private void materialTextfield1_TextChanged(object sender, EventArgs e)
        {
            var result = CardManagementBus.Instance.Search(tb_search.Text).ToList();
            if(result.Count > 0)
            {
                LoadData(result);
            }
            else
            {
                LoadData();
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != -1)
            {
                if (statusComboBox.SelectedIndex == 1)
                    sortStatus = "false";
                else if (statusComboBox.SelectedIndex == 2)
                    sortStatus = "true";
                else sortStatus = null;
            }
            else sortStatus = null;
            if (typeComboBox.SelectedIndex != -1)
            {
                sortType = typeComboBox.SelectedItem.ToString();
            }
            else sortType = null;
            LoadData();
        }
    }
}
