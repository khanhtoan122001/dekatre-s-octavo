using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;
using LiveCharts;
using LiveCharts.Wpf;

namespace dekatreís_octavo.View
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
            myChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Test 1",
                    Values = new ChartValues<double> { 3, 5, 7, 4 }
                },
                new LineSeries
                {
                    Title = "Test 2",
                    Values = new ChartValues<decimal> { 5, 6, 2, 7 }
                }
            };
            myChart.LegendLocation = LegendLocation.Right;

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
            {
                Title = "Maria",
                Values = new ChartValues<double> {3},
                PushOut = 15,
                DataLabels = true,
                //LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Charles",
                Values = new ChartValues<double> {4},
                DataLabels = true,
                //LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Frida",
                Values = new ChartValues<double> {6},
                DataLabels = true,
                //LabelPoint = labelPoint
            },
            new PieSeries
            {
                Title = "Frederic",
                Values = new ChartValues<double> {2},
                DataLabels = true,
                //LabelPoint = labelPoint
            }
            };
            //mySeries.Stroke = System.Windows.Media.Brushes.Red;
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
