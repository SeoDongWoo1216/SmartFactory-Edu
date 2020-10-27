using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_005
{
    public partial class Form1 : Form
    {
        Bitmap HumanFB;  // 휴먼(Human) = 'a'
        Bitmap HumanR;
        Bitmap HumanL;
        Bitmap Box;      // 박스(Box) = 'B'
        Bitmap Wall;     // 벽(wall) = '#'
        Bitmap Point;    // 도착점(Point) = '.'
        Bitmap Ground;   // 배경(Ground) = 'G'
        Bitmap Road;   // 길(Road) = ' '


        string[] Map;
        Point Human = new Point();
        int HumanX;  // Human
        int HumanY;

        int iX;
        int iY;
        const int XPixel = 50;
        const int YPixel = 50;
        const int XTile = 16;
        const int YTile = 10;
        public Form1()
        {
            InitializeComponent();

            ClientSize = new Size(XPixel * XTile, YPixel * YTile); // 클라이언트 폼 크기 설정 메서드

            Wall = new Bitmap(Properties.Resources.Wall);  // 이미지 할당은 생성자에서 이루어짐
            HumanFB = new Bitmap(Properties.Resources.HumanFB);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            Box = new Bitmap(Properties.Resources.Box);
            Point = new Bitmap(Properties.Resources.Point);
            Ground = new Bitmap(Properties.Resources.Ground);
            Road = new Bitmap(Properties.Resources.Road);

            Map = new string[YTile]    // YTile만큼의 배열 생성(세로)
            { 
              "GGGGGGGGGGGGGGGG", // 0
              "G##############G", // 1
              "G##### ########G", // 2
              "G##### ########G", // 3
              "G##   @B  .####G", // 4
              "G##### ########G", // 5
              "G##### ########G", // 6
              "G##### ########G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
            };

            //string Temp= "Apple";
            //char[] Test = Temp.ToCharArray();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)  // 맵핑을 통해 이미지들을 그려주는 이벤트 구문
        {
            Bitmap aBitmap;  // 하드코딩 방지를 위해 그릴때 임시 변수 aBitmap 선언
            for (int iY = 0; iY < YTile; ++iY)
            {
                for (int iX = 0; iX < XTile; ++iX)
                {
                    switch (Map[iY][iX]) // Map 배열의 iY줄의 iX의 값을 보는 조건문
                    {
                        case '#':
                            aBitmap = Wall;
                            break;
                        case '@':
                            aBitmap = HumanFB;
                            HumanX = iX;    // 지금 @(HumanFB)의 좌표를 저장
                            HumanY = iY;
                            //MessageBox.Show(string.Format("{0}, {1}", iX, iY));
                            break;
                        case ' ':
                            aBitmap = Road;
                            break;
                        case 'G':
                            aBitmap = Ground;
                            break;
                        case '.':
                            aBitmap = Point;
                            break;
                        case 'B':
                            aBitmap = Box;
                            break;
                        default:    // case문에 해당되지 않는 경우가 생길때는 Road로 출력
                            aBitmap = Road;
                            break;

                    }

                    e.Graphics.DrawImage(aBitmap, iX * XPixel, iY * YPixel);
                }
            }
           

        }
    }
}

