using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20200909_007
{
    public partial class Form1 : Form
    {
        List<string> Hour = new List<string>();
        List<string> Temp = new List<string>();
        List<string> WfKor = new List<string>();
        List<string> WdKor = new List<string>();
        int[] WfCount = new int[4] {0,0,0,0};
        int[] WdCount = new int[8] {0,0,0,0,0,0,0,0};
        public Form1()
        {
            InitializeComponent();
            this.Text = "부산시 사상구 괘법동의 날씨";

            XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2653062000");
            var XMLData = from Temp in aXElement.Descendants("data")
                          select new Weather()
                          {
                              Hour = Temp.Element("hour").Value,
                              Temp = Temp.Element("temp").Value,
                              WdKor = Temp.Element("wdKor").Value,
                              WfKor = Temp.Element("wfKor").Value
                          };
            
            foreach (var iTemp in XMLData)
            {
                Hour.Add(iTemp.Hour);
                Temp.Add(iTemp.Temp);

                WdKor.Add(iTemp.WdKor);
                WdKorCount(iTemp.WdKor);

                WfKor.Add(iTemp.WfKor);
                WfKorCount(iTemp.WfKor);
            }
        }
        public void WdKorCount(string WdKor)  // 바람카운트 저장
        {
            string a = WdKor;
            if (a == "동")
                ++WdCount[0];
            else if (a == "북동")
                ++WdCount[1];
            else if (a == "북")
                ++WdCount[2];
            else if (a == "북서")
                ++WdCount[3];
            else if (a == "서")
                ++WdCount[4];
            else if (a == "남서")
                ++WdCount[5];
            else if (a == "남")
                ++WdCount[6];
            else if (a == "남동")
                ++WdCount[7];
        }
        public void WfKorCount(string WfKor)  // 날씨카운트 저장
        {
            string a = WfKor;
            if (a == "맑음")
                ++WfCount[0];
            else if (a == "구름 많음")
                ++WfCount[1];
            else if (a == "흐림")
                ++WfCount[2];
            else if (a == "비")
                ++WfCount[3];
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = true;
        }

        // 온도 출력
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.DataBindXY(Hour, Temp);
            chart1.Series[0].LegendText = "온도";
        }

        // 날씨 출력
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Pie;

            chart1.Series[0].Points.Add(WfCount[0]);
            chart1.Series[0].Points.Add(WfCount[1]);
            chart1.Series[0].Points.Add(WfCount[2]);
            chart1.Series[0].Points.Add(WfCount[3]);

            chart1.Series[0].Points[0].LegendText = "맑음";
            chart1.Series[0].Points[1].LegendText = "구름 많음";
            chart1.Series[0].Points[2].LegendText = "비";
            chart1.Series[0].Points[3].LegendText = "흐림";
        }

        // 풍향 출력
        private void button3_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            foreach (var i in WdCount)
            {
                chart1.Series[0].Points.Add(WdCount[i]);
            }
            chart1.Series[0].Points[0].LegendText = "동풍";
            chart1.Series[0].Points[1].LegendText = "북동풍";
            chart1.Series[0].Points[2].LegendText = "북풍";
            chart1.Series[0].Points[3].LegendText = "북서풍";
            chart1.Series[0].Points[4].LegendText = "서풍";
            chart1.Series[0].Points[5].LegendText = "남서풍";
            chart1.Series[0].Points[6].LegendText = "남풍";
            chart1.Series[0].Points[7].LegendText = "남동풍";
        }
    }
}