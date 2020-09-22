using System;
using System.Windows.Forms;
using SharpPcap;

namespace _20200825_004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CaptureDeviceList NicList = CaptureDeviceList.Instance;
            //MessageBox.Show(NicList.Count.ToString());

            //string NicListResult = "";
            //foreach (var Temp in NicList)
            //{
            //    NicListResult += (Temp + "\n");
            //    MessageBox.Show(NicListResult);
            //    Temp.ToString().Substring(Temp.ToString().IndexOf("FriendlyName"), 10);
            //}
     
            CaptureDeviceList NicList = CaptureDeviceList.Instance;
            string NicListResult = "";
            foreach (var Temp in NicList)
            {
                string[] arrTemp = Temp.ToString().Split('\n');
                NicListResult += (arrTemp[1].Substring("FriendlyName: ".Length) + "\n");


                //string Temp2 
                //    = Temp.ToString().Substring(Temp.ToString(
                //).IndexOf("FriendlyName") + "FriendlyName".Length, 10);
                //NicListResult += (Temp2 + "\n");
            }
            MessageBox.Show(NicListResult);


            Button aButton2 = new Button();
            aButton2.Text = "button2";
            aButton2.Name = "button2";
            Controls.Add(aButton2);

        }
    }
}