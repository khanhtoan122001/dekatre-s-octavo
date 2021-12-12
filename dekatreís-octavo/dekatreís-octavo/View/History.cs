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
        public void LoadData()
        {
            var result = ReportBus.Instance.GetCT_BaoCaoLichSuHoatDongs(dateTimePicker1.Value.Date);
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
    }
}
