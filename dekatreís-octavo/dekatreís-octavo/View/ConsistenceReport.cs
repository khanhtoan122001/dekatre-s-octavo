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
        bool DailyReport = false;
        public ConsistenceReport()
        {
            InitializeComponent();
            InitChart();
        }

        private void InitChart()
        {
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
            if(rb_Month.Checked)
                nam = Convert.ToInt32(yearComboBox.SelectedItem);
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rb_Month.Checked)
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
            if(rb_Day.Checked)
            {
                DateTime date = dateTimePicker1.Value.Date;
                list = list.Where(p => p.Ngay == date).ToList();
                LoadChartByDay(list);
                return;
            }
            LoadChartByMonth(list);
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {

        }

        private void containedButton1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (rb_Day.Checked)
            {
                thang = dateTimePicker1.Value.Month;
                nam = dateTimePicker1.Value.Year;
            }
        }

        private void LoadChartByMonth(List<BaoCaoMatDoGuiXe> chartValue)
        {
            rpChart.Series.Clear();
            
            List<int> vao = new List<int>();
            int maxday = DateTime.DaysInMonth(chartValue[0].Ngay.Value.Year, chartValue[0].Ngay.Value.Month);
            int max = 0, min = 32;
            for(int i = 1; i < maxday; i++)
            {
                var result = (from c in chartValue
                              where c.Ngay.Value.Day == i
                              select c).ToList();
                if (result.Count != 0)
                {
                    int count = 0;
                    foreach(var c in result)
                    {
                        count += (c.TongXeVao.Value);
                    }
                    vao.Add(count);
                    if (result[0].Ngay.Value.Day > max) max = result[0].Ngay.Value.Day;
                    if (result[0].Ngay.Value.Day < min) min = result[0].Ngay.Value.Day;
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

            List<string> s = new List<string>();
            for (int i = 1; i <= maxday; i++)
            {
                s.Add(i.ToString());
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

            rpChart.AxisX[0].MinValue = min;
            rpChart.AxisX[0].MaxValue = max;
            rpChart.AxisX[0].Separator.Step = 1;
        }
        private void LoadChartByDay(List<BaoCaoMatDoGuiXe> chartValue)
        {
            rpChart.Series.Clear();
            List<int> vao = new List<int>(), ra = new List<int>();

            for(int i = 0; i <= 24;i++)
            {
                var result = (from c in chartValue
                              where c.Gio == i
                              select c).FirstOrDefault();
                if(result != null)
                {
                    vao.Add(result.TongXeVao.Value);
                    ra.Add(result.TongXeRa.Value);
                }
                else
                {
                    vao.Add(0);
                    ra.Add(0);
                }
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

            List<string> s = new List<string>();
            for (int i = 0; i < 25; i++)
            {
                s.Add(i.ToString());
            }
            rpChart.AxisX = new AxesCollection()
            {
                new Axis
                {
                    Title = "Hour",
                    Labels = s,
                    FontSize = 15,
                }
            };

            rpChart.AxisX[0].MinValue = 0;
            rpChart.AxisX[0].MaxValue = 24;
            rpChart.AxisX[0].Separator.Step = 1;
        }
    }
}
