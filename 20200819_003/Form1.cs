using System;
using System.Windows.Forms;
namespace _20200819_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("이름을 입력하세요", "Warning");
            else
                label2.Text = textBox1.Text + "님! 안녕하세요!";
        }
    }
}