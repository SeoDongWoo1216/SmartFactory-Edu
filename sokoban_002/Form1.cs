using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_002
{
    public partial class Form1 : Form
    {
        int iX = 150;  // 그림의 좌표값 변수

        int iY = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 그래픽스 객체
            // Graphics g = CreateGraphics();

            // 비트맵 로드
            // 첫번째 방법 : 컴퓨터안에 있는 파일 불러오기
            //Bitmap aBitmap = new Bitmap(@"C:\Users\admin\Desktop\소코반복습\1-2.bmp");
            //e.Graphics.DrawImage(aBitmap, 0, 0);  // 비트맵을 그리는 구문

            //e.Graphics.DrawImage(이미지, x좌표, y좌표);
            //e.Graphics.DrawImage(이미지, x좌표, y좌표, 너비, 높이);  // 둘중 하나만써도 상관없다.


            // 두번째 방법 : 리소스에 저장해서 불러오기
            // 리소스 디렉터리에 저장되어있으면 프로젝트를 통째로 옮겨서 할때 편하다.(파일을 따로 들고있지않아도된다)
            //Bitmap aBitmap1 = new Bitmap(Properties.Resources.Image1);
            //Bitmap aBitmap2 = new Bitmap(Properties.Resources._1);
            //e.Graphics.DrawImage(aBitmap1, 0, 0);
            //e.Graphics.DrawImage(aBitmap2, 100, 100);

            Bitmap aBitmap = new Bitmap(Properties.Resources.Image1);
            e.Graphics.DrawImage(aBitmap, iX, iY);

            // 비트맵 그리기

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Up:
                    iY -= 5;
                    break;
                case Keys.Down:
                    iY += 5;
                    break;
                case Keys.Left:
                    iX -= 5;
                    break;
                case Keys.Right:
                    iX += 5;
                    break;
            }   

            this.Invalidate();  // 다시 그려주는 메서드

        }
    }
}
