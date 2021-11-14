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
            var result = CardManagementBus.Instance.GetTheXes().ToList();
            foreach (TheXe i in result)
            {
                cardList.Items.Add(new ListViewItem(new string[] { i.IDThe.ToString(), i.ChuSoHuu, i.LoaiThe.ToString(), i.NgayTao.ToString() }));
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

        private void cardList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
