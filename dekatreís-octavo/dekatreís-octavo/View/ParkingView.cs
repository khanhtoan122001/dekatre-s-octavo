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
    public partial class ParkingView : UserControl
    {
        public ParkingView()
        {
            InitializeComponent();
        }

        private void materialTextfield1_TextChanged(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            var list = GuiNhanXeBus.Instance.GetTheXesEnable();
            foreach(TheXe i in list)
            {
                cb_ListTheXe.Items.Add(i.IDThe);
            }
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            if (tb_BienSo.Text == "" || cb_ListTheXe.SelectedIndex == -1)
                return;
            GuiNhanXeBus.Instance.GuiXeThuong(Convert.ToInt32(cb_ListTheXe.SelectedItem), tb_BienSo.Text, "");
            this.LoadData();
        }
    }
}
