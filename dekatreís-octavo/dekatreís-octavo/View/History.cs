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
    public partial class History : UserControl
    {
        public History()
        {
            InitializeComponent();
        }
        public void LoadData(List<CT_BaoCaoLichSuHoatDong> list = null)
        {
            var result = checkbox.Checked? ReportBus.Instance.GetCT_BaoCaoLichSuHoatDongs(dateTimePicker1.Value.Date) : ReportBus.Instance.GetCT_BaoCaoLichSuHoatDongs();
            if (list != null)
                result = list;
            historyList.Items.Clear();
            foreach (CT_BaoCaoLichSuHoatDong i in result)
            {
                string hoatdong = DataProvider.Instance.db.ThamSoes.Find(i.BaoCaoLichSuHoatDong.HoatDong).TenThamSo;
                
                historyList.Items.Add(new ListViewItem(new string[] { i.IDCTBaoCao.ToString(), i.ThoiGian.ToString(), hoatdong, i.BienSo }));
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            List<CT_BaoCaoLichSuHoatDong> list;
            if (checkbox.Checked)
                list = ReportBus.Instance.SearchCT_HoatDong(searchTextBox.Text, dateTimePicker1.Value.Date);
            else
                list = ReportBus.Instance.SearchCT_HoatDong(searchTextBox.Text);
            if (list.Count > 0)
                LoadData(list);
            else
                LoadData();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
