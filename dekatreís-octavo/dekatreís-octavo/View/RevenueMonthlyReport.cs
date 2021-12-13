using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using dekatreís_octavo.Bus;

namespace dekatreís_octavo.View
{
    public partial class RevenueMonthlyReport : UserControl
    {
        public RevenueMonthlyReport()
        {
            InitializeComponent();
        }

        private void RevenueMonthlyReport_Load(object sender, EventArgs e)
        {
            this.splitContainer1.SplitterDistance = (splitContainer1.Width) / 2;
            this.splitContainer2.SplitterDistance = (splitContainer1.Width) / 2;
            tongThuChart.LegendLocation = LegendLocation.Bottom;
            tongChiChart.LegendLocation = LegendLocation.Bottom;
        }
        public void LoadData(int Thang, int Nam)
        {
            List<CT_BaoCaoTongThu> baoCaoTongThuList = ReportBus.Instance.GetCTBaoCaoTongThus(Thang, Nam);
            List<CT_BaoCaoTongChi> baoCaoTongChiList = ReportBus.Instance.GetCTBaoCaoTongChis(Thang, Nam);
            if (baoCaoTongThuList == null)
            {
                tongThuChart.Series.Clear();
            }
            else
            {
                foreach (var CTBaoCao in baoCaoTongThuList)
                {
                    List<Decimal> values = new List<Decimal>();
                    values.Add(CTBaoCao.GiaTri.Value);
                    tongThuChart.Series.Add(new PieSeries 
                    {
                        Title = CTBaoCao.HoatDong,
                        Values = new ChartValues<Decimal>(values),
                        DataLabels = true
                    });
                }
            }
            if (baoCaoTongChiList == null)
            {
                tongThuChart.Series.Clear();
            }
            else
            {
                foreach (var CTBaoCao in baoCaoTongChiList)
                {
                    List<Decimal> values = new List<Decimal>();
                    values.Add(CTBaoCao.GiaTri.Value);
                    tongChiChart.Series.Add(new PieSeries
                    {
                        Title = CTBaoCao.HoatDong,
                        Values = new ChartValues<Decimal>(values),
                        DataLabels = true
                    });
                }
            }
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            LoadData(monthComboBox.SelectedIndex + 1, Convert.ToInt32(yearComboBox.SelectedItem));
        }
    }
}
