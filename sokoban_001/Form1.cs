using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_001
{
    public partial class Form1 : Form  // Form1이 Form을 상속받는다
    {
        bool LineStatus = false;  // 라인이 그려졌는지, 안그려졌는지 확인하기위한 bool형 변수
        public Form1()  // 생성자, 객체생성
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineStatus = true;  // 버튼 클릭했을때 true로 바뀜

            // 선을 그려보자. (Pen, Graphics가 필요하다)

            // Create pen.(Pen(색깔, 두께))
            Pen aPen = new Pen(Color.DarkViolet, 4);

            // 선을 그릴 점들을 정의
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);

            // 화면에 선을 그린다
            Graphics g = this.CreateGraphics();
            g.DrawLine(aPen, point1, point2);

            // 화면나갔을때 지워지는 이유?? 
            // 리페인트기능이 없기때문.
            // 폼이랑 버튼은 리페인트가 이미 코딩되어있다.
            // Form_Paint 이벤트를 통해 자동으로 그리도록 지정할 수 있다.


            Graphics G = this.CreateGraphics();
            Bitmap aBitmap = new Bitmap(@"C:\Users\admin\Desktop\1.bmp");
            G.DrawImage(aBitmap, 10, 50);
            //DrawImage(그릴 이미지, X좌표, Y좌표, 가로크기, 세로크기)
        }


        // 호출하지 않았는데 호출되는 메서드를 콜백(뒤에서 호출)메서드라고 한다.
        // 운영체제가 호출해주는 메서드

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(LineStatus == true) 
            {
                Pen aPen = new Pen(Color.DarkViolet, 4);

                PointF point1 = new PointF(100.0F, 100.0F);
                PointF point2 = new PointF(500.0F, 100.0F);

                Graphics g = this.CreateGraphics();
                g.DrawLine(aPen, point1, point2);
            }

            //Graphics G = this.CreateGraphics();
            //Bitmap aBitmap = new Bitmap(@"C:\Users\admin\Desktop\1.bmp");
            //G.DrawImage(aBitmap, 10, 10);
            //DrawImage(그릴 이미지, X좌표, Y좌표, 가로크기, 세로크기)

        }
    }
}
