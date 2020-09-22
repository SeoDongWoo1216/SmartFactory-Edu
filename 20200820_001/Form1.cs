using System;
using System.Windows.Forms;
namespace _20200820_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                string str;
                str = "입사일: " + txtDate.Text + "\n";
                str += "우편번호: " + txtPost.Text + "\n";
                str += "주소: " + txtAddr.Text + "\n";
                str += "휴대폰번호: " + txtPhone.Text + "\n";
                str += "주민등록번호: " + txtId.Text + "\n";
                str += "이메일: " + txtEmail.Text + "\n";

                MessageBox.Show(str, "개인정보");
        }
    }
}
