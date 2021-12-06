using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using dekatreís_octavo.Bus;

namespace dekatreís_octavo.View
{
    public partial class ConsistenceReport : UserControl
    {
        int thang, nam;
        public ConsistenceReport()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
            string[] s = new string[31];
            for (int i = 0; i < 31; i++)
            {
                s[i] = (i + 1).ToString();
            }
            rpChart.AxisX = new AxesCollection()
            {
                new Axis
                {
                    Title = "Day",
                    Labels = s,
                    FontSize = 15
                }
            };
            rpChart.LegendLocation = LegendLocation.Bottom;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nam = Convert.ToInt32(yearComboBox.SelectedItem);
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thang = monthComboBox.SelectedIndex + 1;
            LoadData();
        }

        public void LoadData()
        {
            if (nam == 0) nam = DateTime.Now.Year;
            if (thang == 0) thang = DateTime.Now.Month;
            var list = ReportBus.Instance.GetBaoCaoMatDoGuiXes(thang, nam);
            var years = (from c in DataProvider.Instance.db.BaoCaoMatDoGuiXes
                                        select c.Ngay.Value.Year).Distinct().ToList();
            foreach(int i in years)
            {
                yearComboBox.Items.Add(i.ToString());
            }
            LoadChart(list);
        }

        private void LoadChart(List<BaoCaoMatDoGuiXe> chartValue)
        {
            rpChart.Series.Clear();
            List<int> vao = new List<int>(), ra = new List<int>();
            foreach(var i in chartValue)
            {
                vao.Add((int)i.TongXeVao);
                ra.Add((int)i.TongXeRa);
            }
            rpChart.Series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Xe vào",
                    Values = new ChartValues<int>(vao)
                },
                new LineSeries
                {
                    Title = "Xe ra",
                    Values = new ChartValues<int>(ra)
                }
            };
        }
    }
}
