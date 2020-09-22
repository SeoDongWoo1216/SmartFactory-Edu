using System;
using System.Drawing;
using System.Windows.Forms;

namespace _20200819_002
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMyForm();
        }

        private static void CreateMyForm()
        {
            Form form1 = new Form();     // 새로운 폼 객체를 만들고 이름을 form1으로 한다.

            Button button1 = new Button();   // 2개의 버튼 객체를 만들고 button1과 button2로 이름을 준다.
            Button button2 = new Button();

            button1.Text = "OK";    // button1의 Text 속성을 "OK"로한다. 이렇게하면 버튼 위에 "OK"라는 글자가 나타난다.
            button1.Location = new Point(10, 10); // button1의 위치를 정해주기위해 Location 속성을 new Point(10, 10)으로 설정한다. 버튼의 좌상단 좌표가 (10, 10)이 된다.
            button2.Text = "Cancel";  // button2의 Text 속성을 "Cancel"로 한다. 버튼 위에 "Cancel" 라는 글자가 나타난다.
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);  // button2의 위치를 button1아래 10만큼 떨어진 곳으로 설정한다.
            
            form1.Text = "My Dialog Box";  // form1의 Text 속성을 "My Dialog Box"로 설정한다. 폼의 타이틀이 바뀌어져 있을 것이다.

            button1.Click += Button1_Click;    // 버튼 클릭은 맽 밑에 메서드로 추가되어있다

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterScreen;

            // 폼에 버튼 추가하기
            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            //폼에 모달 다이아로그 박스를 보여주기
            form1.ShowDialog(); // form1을 띄워서 form1과 그 안에 있는 버튼을 볼 수 있다.
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK Button을 클릭했습니다");      // 버튼을 클릭했을때 출력하는 메세지를 설정해준다.
        }
    }
}
