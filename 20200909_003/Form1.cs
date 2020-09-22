using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20200909_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Graph using Chart";
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            chart1.ChartAreas[0].BackColor = Color.Black; // 배경색을 검은색으로 설정

            //ChartArea X축과 Y축을 설정
            chart1.ChartAreas[0].AxisX.Minimum = -20;
            chart1.ChartAreas[0].AxisX.Maximum = 20;
            chart1.ChartAreas[0].AxisX.Interval = 2;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas[0].AxisY.Minimum = -2;
            chart1.ChartAreas[0].AxisY.Maximum = 2;
            chart1.ChartAreas[0].AxisY.Interval = 0.5;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            //Series 설정(sin)
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = Color.LightGreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[0].LegendText = "sin(x)/x";

            //Series 추가, 설정(Cos)
            if (chart1.Series.Count == 1)
            {
                chart1.Series.Add("Cos");
                chart1.Series["Cos"].ChartType = SeriesChartType.Line;
                chart1.Series["Cos"].Color = Color.Orange;
                chart1.Series["Cos"].BorderWidth = 2;
                chart1.Series["Cos"].LegendText = "cos(x)/x";
            }
            for(double x = -20; x<20; x += 0.1)
            {
                double y = Math.Sin(x) / x;
                chart1.Series[0].Points.AddXY(x, y);
                y = Math.Cos(x) / x;
                chart1.Series["Cos"].Points.AddXY(x, y);
            }
        }
    }
}