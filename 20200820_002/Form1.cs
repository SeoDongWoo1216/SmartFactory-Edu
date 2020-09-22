using System;
using System.Windows.Forms;

namespace _20200820_002
{
    public partial class Form1 : Form
    {
        //var는 메소드안에서 사용가능
        private int CountMS = 0;
        private int CountM = 0;
        private int CountS = 0;
        private bool Toggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) // 숫자만 바꾸는 Tick
        {
            ++CountMS;
            if (CountMS == 60)
            {
                CountMS = 0;
                ++CountS;
                if (CountS == 5)
                {
                    CountS = 0;
                    ++CountM;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)// 비주얼 Tick
        {
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Toggle == false)
            {
                timer1.Start();
                timer2.Start();
                Toggle = true;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Toggle = false;
            }
        }


        //리셋 버튼(클릭시 값들이 초기화, 라벨이 0으로 표시)
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            Toggle = false;
            CountM = 0;
            CountMS = 0;
            CountS = 0;
            DispM.Text = CountM.ToString();
            DispS.Text = CountS.ToString();
            DispMS.Text = CountMS.ToString();
        }
    }
}
