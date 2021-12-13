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
        bool editting = false;
        public EditCard()
        {
            InitializeComponent();
        }

        private void LoadLoaiThe()
        {
            foreach (LoaiThe i in LoaiTheBus.Instance.GetLoaiThes().ToList())
            {
                cb_LoaiThe.Items.Add(i.TenLoai);
            }
            //cb_LoaiThe.DisplayMember = "TenLoai";
        }

        private void bt_Confirm_Click(object sender, EventArgs e)
        {
            if (cb_LoaiThe.SelectedIndex == -1)
                return;
            int idLoai = LoaiTheBus.Instance.GetIDTheByTen(cb_LoaiThe.SelectedItem.ToString());
            var result = CardManagementBus.Instance.EditCard(selected, tb_TenChuSoHuu.Text, tb_TenXe.Text, tb_BienSo.Text, idLoai);
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
            LoadLoaiThe();
            TheXe the = CardManagementBus.Instance.GetTheXeWithID(selected);
            tb_BienSo.Text = the.BienSoXe;
            cb_LoaiThe.SelectedIndex = (int)the.LoaiThe - 1;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!editting)
            {
                editButton.Text = "Lưu";
                startDate.ReadOnly = false;
                tb_BienSo.ReadOnly = false;
                inTime.ReadOnly = false;
                editting = true;
            }
            else
            {
                editting = false;
                startDate.ReadOnly = true;
                tb_BienSo.ReadOnly = true;
                inTime.ReadOnly = true;
                editButton.Text = "Chỉnh sửa";
            }    
        }
    }
}
