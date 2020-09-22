using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleSample
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);
            chart1.Series[0].Points.Add(list[0]);
            chart1.Series[0].Points.Add(list[1]);
            chart1.Series[0].Points.Add(list[2]);
            chart1.Series[0].Points.Add(list[3]);
            chart1.Series[0].Points[0].LegendText = "맑음";
            chart1.Series[0].Points[1].LegendText = "구름 많음";
            chart1.Series[0].Points[2].LegendText = "비";
            chart1.Series[0].Points[3].LegendText = "흐림";
        }
    }
}
