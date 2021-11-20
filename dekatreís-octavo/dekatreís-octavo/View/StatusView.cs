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
    public partial class StatusView : Form
    {
        public StatusView()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            var result = CardManagementBus.Instance.GetTheXes("", "false").ToList();
            int c = 0;
            statusList.Items.Clear();
            foreach(TheXe i in result)
            {
                c++;
                statusList.Items.Add(new ListViewItem(new string[] { c.ToString(), i.IDThe.ToString(), i.BienSoXe }));
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
