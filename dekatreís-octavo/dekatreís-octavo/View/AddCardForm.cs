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
    public partial class AddCardForm : Form
    {
        QuanLyDoXeEntities1 db = DataProvider.Instance.db;
        public AddCardForm()
        {
            InitializeComponent();
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            var result = CardManagementBus.Instance.AddCard(tb_TenChuSoHuu.Text, tb_TenXe.Text, tb_BienSo.Text, cb_LoaiThe.SelectedIndex);
            if(result)
            {
                MessageBox.Show("Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void tb_BienSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_LoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_TenXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TenChuSoHuu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
