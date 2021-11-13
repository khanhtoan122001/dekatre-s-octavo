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
    public partial class EditCard : Form
    {
        public int selected;
        public EditCard()
        {
            InitializeComponent();
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            var result = CardManagementBus.Instance.EditCard(selected, tb_TenChuSoHuu.Text, tb_TenXe.Text, tb_BienSo.Text, cb_LoaiThe.SelectedIndex);
            if (result)
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void EditCard_Load(object sender, EventArgs e)
        {
            TheXe the = CardManagementBus.Instance.GetTheXeWithID(selected);
            tb_TenChuSoHuu.Text = the.ChuSoHuu;
            tb_BienSo.Text = the.BienSoXe;
            tb_TenXe.Text = the.TenXe;
            cb_LoaiThe.SelectedIndex = (int)the.LoaiThe - 1;
        }
    }
}
