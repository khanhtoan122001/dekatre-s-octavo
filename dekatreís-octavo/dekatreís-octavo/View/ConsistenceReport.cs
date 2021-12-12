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
                    FontSize = 15,
                }
            };
            rpChart.AxisY = new AxesCollection()
            {
                new Axis
                {
                    MinValue = 0
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
        }

        public void LoadData()
        {
            if (nam == 0) nam = DateTime.Now.Year;
            if (thang == 0) thang = DateTime.Now.Month;
            var list = ReportBus.Instance.GetBaoCaoMatDoGuiXes(thang, nam);
            var years = (from c in DataProvider.Instance.db.BaoCaoMatDoGuiXes
                                        select c.Ngay.Value.Year).Distinct().ToList();
            yearComboBox.Items.Clear();
            foreach(int i in years)
            {
                yearComboBox.Items.Add(i.ToString());
            }
            LoadChart(list);
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {

        }

        private void containedButton1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadChart(List<BaoCaoMatDoGuiXe> chartValue)
        {
            rpChart.Series.Clear();
            
            List<int> vao = new List<int>();
            int maxday = DateTime.DaysInMonth(chartValue[0].Ngay.Value.Year, chartValue[0].Ngay.Value.Month);
            int max = 0, min = 32;
            for(int i = 1; i < maxday; i++)
            {
                var result = (from c in chartValue
                              where c.Ngay.Value.Day == i
                              select c).FirstOrDefault();
                if (result != null)
                {
                    vao.Add(result.TongXeVao.Value);
                    if (result.Ngay.Value.Day > max) max = result.Ngay.Value.Day;
                    if (result.Ngay.Value.Day < min) min = result.Ngay.Value.Day;
                }
                else
                    vao.Add(0);
            }

            rpChart.Series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Xe vào",
                    Values = new ChartValues<int>(vao)
                },
                //new LineSeries
                //{
                //    Title = "Xe ra",
                //    Values = new ChartValues<int>(ra)
                //}
            };

            rpChart.AxisX[0].MinValue = min;
            rpChart.AxisX[0].MaxValue = max;
            rpChart.AxisX[0].Separator.Step = 1;
        }
    }
}
