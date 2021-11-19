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

        public void LoadData()
        {
            cardList.Items.Clear();
            typeComboBox.Items.Clear();
            var result = CardManagementBus.Instance.GetTheXes(sortType, sortStatus).ToList();
            foreach (TheXe i in result)
            {
                string trangthai = (bool)i.Status ? "Rảnh" : "Bận";
                string date = i.LoaiThe1.TenLoai == "Thẻ tháng" ? i.NgayTao.Value.Date.ToString() : "";
                cardList.Items.Add(new ListViewItem(
                    new string[] { i.IDThe.ToString(), i.ChuSoHuu, i.LoaiThe1.TenLoai, trangthai, date }));
            }
            List<string> list = db.LoaiThes.Select(p => p.TenLoai).ToList();
            foreach(string i in list)
            {
                typeComboBox.Items.Add(i);
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
                MessageBox.Show("Thành công");
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

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex != -1)
            {
                if (statusComboBox.SelectedIndex == 0)
                    sortStatus = "false";
                else sortStatus = "true";
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
