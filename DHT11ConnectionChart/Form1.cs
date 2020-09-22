using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace DHT11ConnectionChart
{
    public partial class Form1 : Form
    {
        private static int DataSize = 300;
        private static string TName      = "tblSensorDHT11";  // 테이블 이름을 string화(하드코딩 방지)
        private static string QueryLogin = "SERVER = 192.168.0.161; DATABASE = mydb; UID=root; PASSWORD=1234;";

        private static string QueryTable = "SELECT * FROM " + TName + " ORDER BY TIME DESC LIMIT 150";
        private static string QueryTable1 = QueryTable + 1;
        private static string QueryTable12 = QueryTable + DataSize.ToString();

        private bool TimerStatus;
        private void ReflashOn()
        {
            TimerStatus = true;
            timer1.Start();
            button2.Text = "그래프 정지";
        }

        private void ReflashOff()
        {
            TimerStatus = false;
            timer1.Stop();
            button2.Text = "그래프 시작";
        }

        private void ReflashToggle()
        {
            if(false == TimerStatus)  // 타이머가 꺼졌을때
            {
                ReflashOn();
            }
            else
            {
                ReflashOff();
            }
        }

        private void DataUpdate()
        {
            DataSet aDataSet = new DataSet();  // Fill의 인자를위해 DataSet 객체 생성
            using (MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable1, aMySqlConnection);  // 첫번째 인자는 쿼리테이블, 두번째인자는 using으로 생성한 객체
                aMySqlDataAdapter.Fill(aDataSet, TName);

            }
            DataRow Temp = aDataSet.Tables[TName].Rows[0];  // 한개를 가져와서 Temp에 대입
            chart1.Series[0].Points.Add(Int32.Parse(Temp["TEMP"].ToString()));  // 온습도 추출해서 해당 차트 시리즈에 대입(차트출력)
            chart1.Series[1].Points.Add(Int32.Parse(Temp["HUMI"].ToString()));
           
            if (chart1.Series[0].Points.Count > DataSize)
            {
                chart1.Series[0].Points.RemoveAt(0); // 하나는 사라지고 하나는 새로 추가되니까 움직이는것처럼 보인다
                chart1.Series[1].Points.RemoveAt(0);
            }
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet aDataSet = new DataSet();  // Fill의 인자를위해 DataSet 객체 생성
            using(MySqlConnection aMySqlConnection = new MySqlConnection(QueryLogin))
            {
                MySqlDataAdapter aMySqlDataAdapter = new MySqlDataAdapter(QueryTable, aMySqlConnection);  // 첫번째 인자는 쿼리테이블, 두번째인자는 using으로 생성한 객체
                aMySqlDataAdapter.Fill(aDataSet, TName);

            }
            List<int> TempData = new List<int>(); // 온습도, 시간 데이터 받아오기위해 List 선언
            List<int> HumiData = new List<int>();
            List<string> TimeList = new List<string>();
            foreach (DataRow Temp in aDataSet.Tables[TName].Rows)  
            {
                TempData.Add(Int32.Parse(Temp["TEMP"].ToString())); // 테이블은 문자열이기때문에 Int32.Parse로 숫자로 변환, 테이블의 "TEMP"를 문자열로 변환한 것을 들고옴
                HumiData.Add(Int32.Parse(Temp["HUMI"].ToString()));
                TimeList.Add(Temp["TIME"].ToString().Substring(8, 4).Insert(2, ":")); // '20200917134242' 의 시간데이터에서 필요한 시간 부분만 추출
            }
            TimeList.Reverse();
            chart1.Series[0].Points.DataBindXY(TimeList, TempData);
            chart1.Series[1].Points.DataBindXY(TimeList, HumiData);
            chart1.Series[0].LegendText = "온도℃";
            chart1.Series[1].LegendText = "습도%";
            ReflashOn();
        }

        // 버튼클릭하면 데이터가 추가되는 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            DataUpdate();
        }

        // 타이머로 자동으로 업데이트 되는 이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataUpdate();
        }

        // 차트 업데이트 시작, 정지 이벤트
        private void button2_Click(object sender, EventArgs e)
        {
            ReflashToggle();
        }
    }
}