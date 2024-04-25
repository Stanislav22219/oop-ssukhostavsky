using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lb8
{
    public partial class Form1 : Form
    {
        private double a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.00}";
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.00}";
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "y";
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.Black;
            chart1.Series[0].LegendText = "Графік функції";
            chart1.Series[0].BorderWidth = 2;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            a = double.Parse(txt.Text);
            chart1.Series[0].Points.Clear();

            for (double t = -Math.PI; t <= Math.PI; t += 0.01)
            {
                if (Math.Abs(t - Math.PI / 2) % Math.PI > 0.01)
                {
                    double x = a * Math.Tan(t);
                    double y = a * Math.Pow(Math.Sin(t), 2);

                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
        }
    }
}
