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
using ListViewSortAnyColumn;

namespace dekatreís_octavo.View
{
    public partial class CardManagement : UserControl
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        string sortType, sortStatus;
        bool flag = true;
        Image image;
        public CardManagement()
        {
            InitializeComponent();
        }

        private void CardManagement_Load(object sender, EventArgs e)
        {
            //this.LoadData();
            pictureBox6.Left = tb_search.Size.Width - 10;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //var addCard = new AddCardForm();
            //addCard.ShowDialog();
            addCard.Visible = true;
            this.LoadData();
        }

        public void LoadData(List<TheXe> thes = null)
        {
            cardList.Items.Clear();
            List<TheXe> result;
            if(thes != null)
                result = thes;
            else
                result = CardManagementBus.Instance.GetTheXes(sortType, sortStatus).ToList();
            foreach (TheXe i in result)
            {
                string trangthai = (bool)i.Status ? "Rảnh" : "Bận";
                string date = i.LoaiThe1.TenLoai == "Thẻ tháng" ? (i.NgayTao == null? "" : i.NgayTao.Value.ToShortDateString()): "";
                cardList.Items.Add(new ListViewItem(
                    new string[] { i.IDThe.ToString(), i.BienSoXe, i.LoaiThe1.TenLoai, trangthai, i.ThoiGianGui.ToString(), date })
                { Tag = i });
            }
            
            if (flag)
            {
                typeComboBox.Items.Clear();
                List<string> list = db.LoaiThes.Select(p => p.TenLoai).ToList();
                typeComboBox.Items.Add("All");
                foreach (string i in list)
                {
                    typeComboBox.Items.Add(i);
                }
                CardManagementBus.Instance.CheckAllow();
                flag = false;
                if (DataProvider.Instance.TaiKhoan.LoaiTaiKhoan1.TenLoai == "staff")
                {
                    addButton.Visible = false;
                    delButton.Visible = false;
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
                inOutButton.Visible = false;
                createButton.Visible = false;
            }
            else
            {
                TheXe the = (TheXe)cardList.SelectedItems[0].Tag;
                if (the.LoaiThe1.TenLoai != "Thẻ tháng")
                {
                    inOutButton.Visible = true;
                    createButton.Visible = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(the.BienSoXe))
                    {
                        createButton.Visible = true;
                        inOutButton.Visible = false;
                    }
                    else
                    {
                        inOutButton.Visible = true;
                        createButton.Visible = false;
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
                the.AnhXe1 = the.AnhXe2 = the.AnhXe3 = the.AnhXe4 = null;
            }
            else
            {
                if (the.LoaiThe1.TenLoai == "Thẻ thường")
                    GuiNhanXeBus.Instance.GuiXeThuong(the.IDThe, bienSo, "");
                else
                    GuiNhanXeBus.Instance.GuiXeTheThang(the.IDThe);
                if (image != null)
                    the.AnhXe1 = ImageHelper.imageToByteArray(image);
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
                    //if()
                    var list = CardManagementBus.Instance.FindByBienSo(inputTextBox.Text);
                    if (list.Where(p => p.LoaiThe1.TenLoai == "Thẻ tháng").Count() == 0)
                    {
                        if (image != null) the.AnhXe1 = ImageHelper.imageToByteArray(image);
                        CardManagementBus.Instance.DangKyTheThang(the.IDThe, inputTextBox.Text);
                    }
                    else
                        MessageBox.Show("Biển số này đã đăng ký thẻ tháng");
                    LoadData();
                }
                else
                {
                    if (CardManagementBus.Instance.FindByBienSo(inputTextBox.Text).Count() == 0)
                        GuiNhan(the, inputTextBox.Text);
                    else
                        MessageBox.Show("Xe này đang ở trong bãi hoặc đã đăng ký thẻ tháng");
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
            if (string.IsNullOrEmpty(tb_search.Text))
                return;
            var result = CardManagementBus.Instance.Search(tb_search.Text).ToList();
            //if(result.Count > 0)
            {
                LoadData(result);
            }
    
        }

        private void listViewSample_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = cardList.ListViewItemSorter as ItemComparer;

            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                cardList.ListViewItemSorter = sorter;
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
            cardList.Sort();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog1.Title = "Save an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var i = LoaiTheBus.Instance.GetIDTheByTen(cb_LoaiThe.SelectedItem.ToString());
            if (i == -1)
                return;
            CardManagementBus.Instance.AddCard(i);
            MessageBox.Show("Thêm thẻ thành công");
            addCard.Visible = false;
            LoadData();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            addCard.Visible = false;
        }

        private void CardManagement_SizeChanged(object sender, EventArgs e)
        {
            int space = cardList.Width - (cardList.Columns[0].Width + cardList.Columns[1].Width + cardList.Columns[2].Width + cardList.Columns[3].Width + cardList.Columns[4].Width + cardList.Columns[5].Width);
            cardList.Columns[4].Width += space / 3;
            cardList.Columns[5].Width += space / 3;
            cardList.Columns[1].Width += space / 3;
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != -1)
            {
                if (statusComboBox.SelectedIndex == 2)
                    sortStatus = "false";
                else if (statusComboBox.SelectedIndex == 1)
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
