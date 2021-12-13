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
using System.IO;
using OfficeOpenXml;

namespace dekatreís_octavo.View
{
    public partial class ConsistenceReport : UserControl
    {
        int thang, nam;
        List<BaoCaoMatDoGuiXe> list;
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
            if (rb_Month.Checked)
            {
                nam = Convert.ToInt32(yearComboBox.SelectedItem);
                bt_refresh.Enabled = true;
            }
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_Month.Checked)
            {
                thang = monthComboBox.SelectedIndex + 1;
                bt_refresh.Enabled = true;
            }
        }

        public void LoadData()
        {
            if (nam == 0) nam = DateTime.Now.Year;
            if (thang == 0) thang = DateTime.Now.Month;
            list = ReportBus.Instance.GetBaoCaoMatDoGuiXes(thang, nam);
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
            rpChart.AxisX.Clear();
            if (chartValue.Count == 0)
            {
                rpChart.Series = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Title = "Xe vào",
                    },
                };
                return;
            }
            List<string> s = new List<string>();
            for (int i = 1; i <= 31; i++)
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
            if (chartValue.Count == 0)
            {
                rpChart.Series = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Title = "Xe vào",
                    },
                };
                rpChart.AxisX[0].MinValue = 1;
                rpChart.AxisX[0].MaxValue = 30;
                return;
            }
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

            

            rpChart.AxisX[0].MinValue = min;
            rpChart.AxisX[0].MaxValue = max;
            rpChart.AxisX[0].Separator.Step = 1;
        }

        private void rb_Month_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Month.Checked)
            {
                yearComboBox.Visible = true;
                monthComboBox.Visible = true;
                dateTimePicker1.Visible = false;
                if (yearComboBox.SelectedIndex != -1)
                    nam = Convert.ToInt32(yearComboBox.SelectedItem);
                if (monthComboBox.SelectedIndex != -1)
                    thang = monthComboBox.SelectedIndex + 1;
            }
        }

        private void rb_Day_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Day.Checked)
            {
                yearComboBox.Visible = false;
                monthComboBox.Visible = false;
                dateTimePicker1.Visible = true;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            ExcelPackage file;
            if (rb_Month.Checked)
            {
                List<BaoCaoMatDoTheoNgay> listBaoCao = new List<BaoCaoMatDoTheoNgay>();
                for (int y = 1; y < 32; y++)
                {
                    var result = (from c in list
                                  where c.Ngay.Value.Day == y
                                  select c).ToList();
                    if (result.Count != 0)
                    {
                        int count = 0;
                        foreach (var c in result)
                        {
                            count += (c.TongXeVao.Value);
                        }
                        listBaoCao.Add(new BaoCaoMatDoTheoNgay() { Id = result[0].IDBaoCao, Date = result[0].Ngay.Value.ToShortDateString(), XeVao = count });
                    }
                }
                file = ExcelHelper.CreateExcelFileByDay(listBaoCao);
            }
            else
            {
                List<BaoCaoMatDoTheoGio> listBaoCao = new List<BaoCaoMatDoTheoGio>();
                for (int i = 0; i <= 24; i++)
                {
                    var result = (from c in list
                                  where c.Gio == i
                                  select c).FirstOrDefault();
                    if (result != null)
                    {
                        listBaoCao.Add(new BaoCaoMatDoTheoGio() { Id = result.IDBaoCao, Date = result.Ngay.Value.ToShortDateString(), Hour = result.Gio.Value, XeVao = result.TongXeVao.Value, XeRa = result.TongXeRa.Value });
                    }
                }
                file = ExcelHelper.CreateExcelFileByHour(listBaoCao);
            }

            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                //File.WriteAllText(filePath, file.Stream.ToString());
                FileStream objFileStrm = File.Create(filePath);
                
                objFileStrm.Close();

                // Write content to excel file 
                File.WriteAllBytes(filePath, file.GetAsByteArray());
                MessageBox.Show("Xuất file thành công");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!");
            }

        }

        private void LoadChartByDay(List<BaoCaoMatDoGuiXe> chartValue)
        {
            rpChart.Series.Clear();
            rpChart.AxisX.Clear();
            List<int> vao = new List<int>(), ra = new List<int>();
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
            if (chartValue.Count == 0)
            {
                rpChart.Series = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Title = "Xe vào",
                    },
                };
                rpChart.Series = new SeriesCollection()
                {
                    new LineSeries
                    {
                        Title = "Xe ra",
                    },
                };
                rpChart.AxisX[0].MinValue = 0;
                rpChart.AxisX[0].MaxValue = 24;
                return;
            }

            for (int i = 0; i <= 24;i++)
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

            

            rpChart.AxisX[0].MinValue = 0;
            rpChart.AxisX[0].MaxValue = 24;
            rpChart.AxisX[0].Separator.Step = 1;
        }
    }
}
