using System.Drawing;
using System.Windows.Forms;

namespace _20200827_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {    
            InitializeComponent();
            TextBox aTextBox = new TextBox();   // textbox 객체 생성
            aTextBox.Location = new Point(60, 30);  // textbox 위치(가로)위치)
            aTextBox.Name = "FactoTB1";    // textbox의 이름
            aTextBox.Size = new Size(200, 51);  // Text박스의 크기
            aTextBox.Text = "됬냐?";
            aTextBox.Multiline = true; // Multiline은 textbox의 세로크기도 조절이 가능하게해준다.
            Controls.Add(aTextBox);
        }
    }
}


           
