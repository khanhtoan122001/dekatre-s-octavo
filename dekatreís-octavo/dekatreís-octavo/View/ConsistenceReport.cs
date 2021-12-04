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

namespace dekatreís_octavo.View
{
    public partial class ConsistenceReport : UserControl
    {
        public ConsistenceReport()
        {
            InitializeComponent();
            string[] s = new string[31];
            for (int i = 0; i < 31; i++) 
            {
                s[i] = (i + 1).ToString();
            }
            rpChart.AxisX = new AxesCollection()
            {               
                new Axis
                {
                    Name = "X",
                    Labels = s,
                    FontSize = 15
                }
            };
        }
    }
}
