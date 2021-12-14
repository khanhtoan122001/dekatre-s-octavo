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
            var result = CardManagementBus.Instance.EditCard(selected, tb_BienSo.Text, idLoai);
            TheXe the = CardManagementBus.Instance.GetTheXeWithID(selected);
            if (anhXe1.Image != null)
                the.AnhXe1 = ImageHelper.imageToByteArray(anhXe1.Image);
            if (anhXe2.Image != null)
                the.AnhXe2 = ImageHelper.imageToByteArray(anhXe2.Image);
            if (anhXe3.Image != null)
                the.AnhXe3 = ImageHelper.imageToByteArray(anhXe3.Image);
            if (anhXe4.Image != null)
                the.AnhXe4 = ImageHelper.imageToByteArray(anhXe4.Image);
            DataProvider.Instance.db.SaveChanges();

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
            if (the.AnhXe1 != null)
                anhXe1.Image = ImageHelper.byteArrayToImage(the.AnhXe1);
            if (the.AnhXe2 != null)
                anhXe2.Image = ImageHelper.byteArrayToImage(the.AnhXe2);
            if (the.AnhXe3 != null)
                anhXe3.Image = ImageHelper.byteArrayToImage(the.AnhXe3);
            if (the.AnhXe4 != null)
                anhXe4.Image = ImageHelper.byteArrayToImage(the.AnhXe4);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (!editting)
            {
                editButton.Text = "Tắt chỉnh sửa";
                startDate.ReadOnly = false;
                tb_BienSo.ReadOnly = false;
                inTime.ReadOnly = false;
                cb_LoaiThe.Enabled = true;
                anhXe1.Enabled = true; anhXe2.Enabled = true; anhXe3.Enabled = true;  anhXe4.Enabled = true;
                editting = true;
            }
            else
            {
                editting = false;
                startDate.ReadOnly = true;
                tb_BienSo.ReadOnly = true;
                inTime.ReadOnly = true;
                cb_LoaiThe.Enabled = false;
                anhXe1.Enabled = false; anhXe2.Enabled = false; anhXe3.Enabled = false; anhXe4.Enabled = false;
                editButton.Text = "Chỉnh sửa";
            }    
        }

        private void anhXe1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog1.Title = "Save an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                anhXe1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void anhXe2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog1.Title = "Save an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                anhXe2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void anhXe3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog1.Title = "Save an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                anhXe3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void anhXe4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
            openFileDialog1.Title = "Save an Image File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                anhXe4.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
