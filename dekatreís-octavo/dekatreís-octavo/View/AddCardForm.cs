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
            if (cb_LoaiThe.SelectedIndex == -1)
                return;
            int idLoai = LoaiTheBus.Instance.GetIDTheByTen(cb_LoaiThe.SelectedItem.ToString());
            var result = CardManagementBus.Instance.AddCard(idLoai);
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
        private void LoadLoaiThe()
        {
            foreach (LoaiThe i in LoaiTheBus.Instance.GetLoaiThes().ToList())
            {
                cb_LoaiThe.Items.Add(i.TenLoai);
            }
            //cb_LoaiThe.DisplayMember = "TenLoai";
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

        private void AddCardForm_Load(object sender, EventArgs e)
        {
            LoadLoaiThe();
        }
    }
}
