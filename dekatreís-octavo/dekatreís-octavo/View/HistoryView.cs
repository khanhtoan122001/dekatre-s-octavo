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
    public partial class HistoryView : Form
    {
        
        public HistoryView()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            var result = ReportBus.Instance.GetCT_BaoCaoLichSuHoatDongs(dateTimePicker.Value.Date);
            historyList.Items.Clear();
            foreach(CT_BaoCaoLichSuHoatDong i in result)
            {
                ThamSo thamSo = ThamSoBus.Instance.GetById((int)i.BaoCaoLichSuHoatDong.HoatDong);
                historyList.Items.Add(new ListViewItem(new string[] { i.IDCTBaoCao.ToString(), i.ThoiGian.ToString(), thamSo.TenThamSo, i.BienSo }));
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
