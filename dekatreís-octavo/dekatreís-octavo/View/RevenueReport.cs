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
    public partial class RevenueReport : UserControl
    {
        public RevenueReport()
        {
            InitializeComponent();
        }

        private void RevenueReport_Load(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tháng",
                Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" },
            });
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
            cartesianChart1.AxisX[0].Separator.Step = 1;

            cartesianChart1.Series = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Tổng thu",
                },
                new LineSeries
                {
                    Title = "Tổng chi",
                }
            };

            cartesianChart1.AxisY = new AxesCollection()
            {
                new Axis
                {
                    MinValue = 0
                }
            };
            cartesianChart1.AxisY[0].Separator.Step = 100000;
        }

        private void containedButton1_Click(object sender, EventArgs e)
        {
            int Nam = Convert.ToInt32(yearComboBox.SelectedItem);
            LoadData(Nam);
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            containedButton1.Enabled = true;
        }

        public void LoadData(int Nam)
        {
            var list = ReportBus.Instance.GetBaoCaoDoanhThuThangs(Nam);
            if (list == null)
            {
                cartesianChart1.Series.Clear();
                cartesianChart1.Series = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Title = "Tổng thu",
                    },
                    new LineSeries
                    {
                        Title = "Tổng chi",
                    }
                };
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            LoadChart(list);
        }

        private void LoadChart(List<BaoCaoDoanhThuThang> chartValue)
        {
            cartesianChart1.Series.Clear();
            List<int> thu = new List<int>(), chi = new List<int>();
            foreach (var i in chartValue)
            {
                while ((thu.Count + 1) != i.Thang)
                    thu.Add(0);
                thu.Add((int)i.TongThu);
                while ((chi.Count + 1) != i.Thang)
                    chi.Add(0);
                chi.Add((int)i.TongChi);
            }
            cartesianChart1.Series = new SeriesCollection()
            {
                new ColumnSeries
                {
                    Title = "Tổng thu",
                    Values = new ChartValues<int>(thu)
                },
                new ColumnSeries
                {
                    Title = "Tổng chi",
                    Values = new ChartValues<int>(chi)
                }
            };
        }
    }
}
