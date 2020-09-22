using System;
using System.Drawing;
using System.Windows.Forms;

namespace _20200820_003_02
{
    public partial class Form1 : Form
    {
        private Timer myTimer = new Timer();
        private DateTime dDay;
        private DateTime tTime;
        private bool setAlarm;
        public Form1()
        {
            InitializeComponent();

            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += myTimer_Tick;
            myTimer.Start();

            tabControl1.SelectedTab = tabPage2;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();
            lblTime.Text = cTime.ToLongTimeString();

            if(setAlarm == true)
            {
                if(dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("Alarm!!");
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(DatePicker.Text);
            tTime = DateTime.Parse(TimePicker.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarm.Text = "Alarm : " + dDay.ToShortTimeString() + " "
                + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarm.Text = "Alarm : ";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
