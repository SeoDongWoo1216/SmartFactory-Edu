using System;
using System.Windows.Forms;
namespace _20200819_005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string checkStates = "";
            CheckBox[] cBox
                = { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };

            foreach(var item in cBox)
            {
                checkStates += string.Format("{0} : {1}\n", item.Text, item.Checked);
                //Console.WriteLine("{0} : {1}\n", item.Text, item.Checked);
            }
            MessageBox.Show(checkStates, "체크박스 상태 메세지");

            string summary = string.Format("좋아하는 과일은 : ");
            foreach (var item in cBox)
            {
                if (item.Checked == true)
                    summary += item.Text + " ";
            }
            MessageBox.Show(summary, "당신이 좋아하는 과일은?");
        }
    }
}
