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
        public CardManagement()
        {
            InitializeComponent();
        }

        private void CardManagement_Load(object sender, EventArgs e)
        {
            var result = CardManagementBus.Instance.GetTheXes().ToList();
            foreach(TheXe i in result)
            {
                cardList.Items.Add(new ListViewItem( new string[] { i.IDThe.ToString(), i.LoaiThe.ToString(), i.NgayTao.ToString() }));
            }
        }
    }
}
