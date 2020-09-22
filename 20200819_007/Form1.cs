using System;
using System.Windows.Forms;
namespace _20200819_007
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "abcd" && txtPassword.Text == "1234")
                txtResult.Text = "로그인 성공";
            else
                txtResult.Text = "로그인 실패";
        }
    }
}