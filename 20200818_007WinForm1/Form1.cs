using System.Windows.Forms;
namespace _20200818_007WinForm1
{
    public partial class Form1 : Form
    {
        bool bButton = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_DoubleClick(object sender, System.EventArgs e)
        {
            if (bButton == false) 
            { 
                FactBtn.Text = "더블 클릭 했구나?";
                bButton = true;
            }
            else
            {
                FactBtn.Text = "또 더블 클릭했구나?";
                bButton = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "마우스 올라오면 이 글이 보인다";
        }

        private void Form1_MouseLeave(object sender, System.EventArgs e)
        {
            Text = "마우스를 떠나보내면 이 글이 보인다";
        }

        private void FactBtn_MouseMove(object sender, MouseEventArgs e)
        {
            FactBtn.Text = "버튼에 마우스 갖다대면 이 글이 보인다.";
        }

        private void FactBtn_MouseLeave(object sender, System.EventArgs e)
        {
            FactBtn.Text = "버튼에 마우스를 떼면 이 글이 보인다.";
        }


        // 텍스트박스1에 글자를 입력하고 엔터를 누르면 발생하는 이벤트
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    FactBtn.Text = textBox1.Text; // FactBtn.Text가 textBox1.text에 대입된다. -> 텍스트박스의 글자가 버튼 글자가 된다.
            //}

            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Text = textBox1.Text; // textBox1.Text가 textBox2.text에 대입된다. -> 텍스트박스1의 글자가 텍스트박스2의 글자가 된다.
            }
        }

        //버튼을 클릭하면 텍스트박스1의 글자가 텍스트박스2에 입력되는 이벤트
        private void FactBtn_Click(object sender, System.EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
