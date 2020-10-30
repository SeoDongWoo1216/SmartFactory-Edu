using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_007_003
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
        Bitmap Road;     // 길(Road) = ' '


        string[,] Map;
        char[][] MapReal;
        Point Human = new Point();
        int HumanX;
        int HumanY;
        int HumanXOld;  // 움직이기전 원래 좌표값을 백업할 변수
        int HumanYOld;

        int iStage;    // 지금의 스테이지가 몇인지 저장할 변수
        bool EndStage;  // 스테이지 끝날때, 안끝날때 bool형 변수

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
            Ground = new Bitmap(Properties.Resources.GND);
            Road = new Bitmap(Properties.Resources.Road);

            iStage = 0;

            Map = new string[,]    // YTile만큼의 배열 생성(세로)
            {
            {
              "GGGGGGGGGGGGGGGG", // 0
              "G##############G", // 1
              "G#####     ####G", // 2
              "G##         ###G", // 3
              "G##  @B.   ####G", // 4
              "G##   B.  #####G", // 5
              "G##       #####G", // 6
              "G##### ########G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
                },

             {
              "GGGGGGGGGGGGGGGG", // 0
              "G##############G", // 1
              "G##          ##G", // 2
              "G##          ##G", // 3
              "G##  @B.     ##G", // 4
              "G##   B.     ##G", // 5
              "G##          ##G", // 6
              "G##         ###G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
                }

            };

            // string Temp= "Apple";
            // char[] Test = Temp.ToCharArray();
            // stub 코드(나무 밑둥 코드)

            MapReal = new char[YTile][];

            for (int i = 0; i < YTile; ++i)
            {
                MapReal[i] = Map[iStage, i].ToCharArray();
            }

        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            EndStage = true;

            Bitmap aBitmap;  // 하드코딩 방지를 위해 그릴때 임시 변수 aBitmap 선언
            for (int iY = 0; iY < YTile; ++iY)
            {
                for (int iX = 0; iX < XTile; ++iX)
                {
                    switch (MapReal[iY][iX]) // Map 배열의 iY줄의 iX의 값을 보는 조건문
                    {
                        case '#':
                            aBitmap = Wall;
                            break;

                        case '@':
                            aBitmap = HumanFB;
                            HumanX = iX;    // 지금 @(HumanFB)의 좌표를 저장
                            HumanY = iY;
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
                            if ('.' != Map[iStage, iY][iX])  // 박스와 점이 겹치지않을때는 스테이지가 계속 유지
                            {
                                EndStage = false;
                            }
                            break;

                        default:    // case문에 해당되지 않는 경우가 생길때는 Road로 출력
                            aBitmap = Road;
                            break;

                    }

                    e.Graphics.DrawImage(aBitmap, iX * XPixel, iY * YPixel);
                }
            }

        }
        private new void Move()
        {
            if ('#' == MapReal[HumanY][HumanX])   // 사람의 왼쪽이 벽이면 return
            {
                return;
            }
            else if ('B' == MapReal[HumanY][HumanX])   // 사람 왼쪽에 박스가 있으면 박스의 위치를 한칸 더 왼쪽에 그려줌(박스 들고 이동되는것처럼 보임)
            {
                if ('#' == MapReal[2 * HumanY - HumanYOld][2 * HumanX - HumanXOld])
                {
                    return;
                }
                if ('B' == MapReal[2 * HumanY - HumanYOld][2 * HumanX - HumanXOld])  // 박스 2개가 겹칠때 못움직이도록
                {
                    return;
                }
                MapReal[2 * HumanY - HumanYOld][2 * HumanX - HumanXOld] = 'B';
            }

            if ('.' == Map[iStage, HumanYOld][HumanXOld])   // 점의 위치에 있을때
            {
                MapReal[HumanYOld][HumanXOld] = '.';   // 원래 Map의 점의 위치일때를 복사해와서 점을 다시 그려준다
            }
            MapReal[HumanY][HumanX] = '@';
        }





        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MapReal[HumanY][HumanX] = ' ';
            HumanXOld = HumanX;
            HumanYOld = HumanY;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    --HumanX;
                    break;
                case Keys.Right:
                    ++HumanX;
                    break;
                case Keys.Up:
                    --HumanY;
                    break;
                case Keys.Down:
                    ++HumanY;
                    break;
                default:
                    MapReal[HumanY][HumanX] = '@';
                    return;
                    // switch문말고 다른 키보드 클릭했을때는 return;
                    // break;하면 invalidate때문에 또 그려지므로 return을 사용하는 것이 맞다.
            }



            if ('.' == Map[iStage, HumanYOld][HumanXOld])   // 점의 위치에 있을때
            {
                MapReal[HumanYOld][HumanXOld] = '.';   // 원래 Map의 점의 위치일때를 복사해와서 점을 다시 그려준다
            }
            MapReal[HumanY][HumanX] = '@';

            Move();
            Invalidate();
            Update();

            if (EndStage)  // EndStage가 true일때 스테이지 종료
            {
                MessageBox.Show("끝남");
            }
        }




        private void Form1_KeyDown1(object sender, KeyEventArgs e)
        {
            MapReal[HumanY][HumanX] = ' ';
            HumanXOld = HumanX;
            HumanYOld = HumanY;

            ////////////////////////////////////////////////////////////////
            /*
            int xPos = HumanX;      // 새로 캐릭터가 이동할 X좌표
            int yPos = HumanY;      // 새로 캐릭터가 이동할 Y좌표
            int xPos2 = HumanX;     // 새로 캐릭터가 이동할 칸에 박스가 있다면 그 박스가 밀려날 X좌표
            int yPos2 = HumanY;     // 새로 캐릭터가 이동할 칸에 박스가 있다면 그 박스가 밀려날 Y좌표
            switch (e.KeyCode)
            {
                case Keys.Left:
                    xPos = HumanX - 1;
                    xPos2 = HumanX - 2;
                    break;
                case Keys.Right:
                    xPos = HumanX + 1;
                    xPos2 = HumanX + 2;
                    break;
                case Keys.Up:
                    yPos = HumanY - 1;
                    yPos2 = HumanY - 2;
                    break;
                case Keys.Down:
                    yPos = HumanY + 1;
                    yPos2 = HumanY + 2;
                    break;
            }

            if (xPos < 0 || xPos >= XTile || 
                yPos < 0 || yPos >= YTile)
            {
                return;   
            }
            else if ('#' == MapReal[yPos][xPos])
            {
                return;  // 벽만났을때
            }
            else if ('B' == MapReal[yPos][xPos])
            {
                if (xPos2 < 0 || xPos2 >= XTile ||
                    yPos2 < 0 || yPos2 >= YTile)
                {
                    return;
                }

                if (MapReal[yPos2][xPos2] == '#' ||
                    MapReal[yPos2][xPos2] == 'B')
                {
                    return;
                }

                MapReal[yPos2][xPos2] = 'B';
            }

            MapReal[yPos][xPos] = '@';
            */
            
            ///////////////////////////////////////////////////////////
            ///
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if ('#' == MapReal[HumanY][HumanX - 1])    // 사람의 왼쪽이 벽이면 return
                    {
                        return;
                    }
                    if ('B' == MapReal[HumanY][HumanX - 1])   // 사람 왼쪽에 박스가 있으면 박스의 위치를 한칸 더 왼쪽에 그려줌(박스 들고 이동되는것처럼 보임)
                    {
                        if ('#' == MapReal[HumanY][HumanX - 2])
                        {
                            return;
                        }
                        if ('B' == MapReal[HumanY][HumanX - 2])  // 박스 2개가 겹칠때 못움직이도록
                        {
                            return;
                        }
                        MapReal[HumanY][HumanX - 2] = 'B';
                    }
                    --HumanX;
                    break;


                case Keys.Right:
                    if ('#' == MapReal[HumanY][HumanX + 1])
                    {
                        return;
                    }

                    if ('B' == MapReal[HumanY][HumanX + 1])
                    {
                        if ('#' == MapReal[HumanY][HumanX + 2])
                        {
                            return;
                        }
                        if ('B' == MapReal[HumanY][HumanX + 2])
                        {
                            return;
                        }
                        MapReal[HumanY][HumanX + 2] = 'B';
                    }

                    ++HumanX;
                    break;


                case Keys.Up:
                    if ('#' == MapReal[HumanY - 1][HumanX])
                    {
                        return;
                    }
                    if ('B' == MapReal[HumanY - 1][HumanX])
                    {
                        if ('#' == MapReal[HumanY - 2][HumanX])
                        {
                            return;
                        }
                        if ('B' == MapReal[HumanY - 2][HumanX])
                        {
                            return;
                        }
                        MapReal[HumanY - 2][HumanX] = 'B';
                    }
                    --HumanY;
                    break;


                case Keys.Down:
                    if ('#' == MapReal[HumanY + 1][HumanX])
                    {
                        return;
                    }

                    if ('B' == MapReal[HumanY + 1][HumanX])
                    {
                        if ('#' == MapReal[HumanY + 2][HumanX])
                        {
                            return;
                        }
                        if ('B' == MapReal[HumanY + 2][HumanX])
                        {
                            return;
                        }
                        MapReal[HumanY + 2][HumanX] = 'B';
                    }
                    ++HumanY;
                    break;


                default:
                    MapReal[HumanY][HumanX] = '@';
                    return;
                    // switch문말고 다른 키보드 클릭했을때는 return;
                    // break;하면 invalidate때문에 또 그려지므로 return을 사용하는 것이 맞다.
            }

            

            if ('.' == Map[iStage, HumanYOld][HumanXOld])   // 점의 위치에 있을때
            {
                MapReal[HumanYOld][HumanXOld] = '.';   // 원래 Map의 점의 위치일때를 복사해와서 점을 다시 그려준다
            }
            MapReal[HumanY][HumanX] = '@';


            Invalidate();
            Update();

            if (EndStage)  // EndStage가 true일때 스테이지 종료
            {
                MessageBox.Show("끝남");
            }
        }



    }
}
