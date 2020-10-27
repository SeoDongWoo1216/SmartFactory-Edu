using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_004
{
    public partial class Form1 : Form
    {
        string Message = "ABCDEF";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Message.Substring(3,1));
            //MessageBox.Show(string.Format("{0}", 'D'));   // 'D'같은 문자를 Format으로 문자열로 만들어서 출력해준다.

            //for (int i = 0; i < Message.Length; i++)
            //{
            //    MessageBox.Show(Message.Substring(i, 1));
            //}

            //for(int i = 0; i< Message.Length; i++)
            //{
            //    MessageBox.Show(string.Format("{0}", Message[i]));
            //}

            foreach (var Temp in Message)
            {
                // MessageBox.Show(string.Format("{0}", Message[Temp])); // 잘못된 코드
                MessageBox.Show(string.Format("{0}", Temp));
            }

        }
    }
}



/*
 클래스는 변수/ 상수(상태), 메서드(행위)를 가지고 있다.
메서드는 ()가 항상 있다.
Format(모양, 형성) 은 이름이 같은 메서드가 있다. -> 겹지정(override)라고 부른다. 이름이 같은 대신 인자로 구분한다.



 키스를 글로배웠다  글 -> 클래스
 내가 키스를 하고있다  -> 인스턴스
 손에 잡히는것을 인스턴스

밖에서 클래스안으로 접근할때
못들어오는 것이 private
무사통과해주는 것이 public
상속 받았니? 물어보는 것이 protected  (상속Y -> 들어옴)(상속 N-> 못들어옴)
 */
