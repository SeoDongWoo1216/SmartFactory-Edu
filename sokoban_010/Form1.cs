using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_010
{
    public partial class Form1 : Form
    {
        Bitmap HumanFB;  // 휴먼(Human) = 'a'
        Bitmap HumanR;
        Bitmap HumanL;
        Bitmap Human;
        Bitmap Box;      // 박스(Box) = 'B'
        Bitmap Wall;     // 벽(wall) = '#'
        Bitmap Point;    // 도착점(Point) = '.'
        Bitmap Ground;   // 배경(Ground) = 'G'
        Bitmap Road;     // 길(Road) = ' '


        string[][] Map;
        char[][] MapReal;
        //Point Human = new Point();
        int HumanX;
        int HumanY;
        int HumanXOld;  // 움직이기전 원래 좌표값을 백업할 변수
        int HumanYOld;

        int iStage;     // 지금의 스테이지가 몇인지 저장할 변수
        int iFStage;    // 마지막 스테이지를 저장할 변수
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
            Human = HumanFB;
            Box = new Bitmap(Properties.Resources.Box);
            Point = new Bitmap(Properties.Resources.Point);
            Ground = new Bitmap(Properties.Resources.GND);
            Road = new Bitmap(Properties.Resources.Road);


            try
            {
                List<string[]> aList = new List<string[]>();
                StreamReader MapFile = new StreamReader(@"Map.txt");
                string Temp = null;
                string[] TempMap = new string[YTile];
                int iCount;
                int iMapCount = 0;

                while (true)  // 전체 맵 로딩
                { 
                
                    for (iCount = 0; iCount < YTile; ++iCount)  // 맵 1개 로딩
                    {
                        Temp = MapFile.ReadLine();

                        if (Temp == null)             // 파일 끝에 도달했을때 Null이면 break;
                        {
                            break;
                        }
                        if (0 == Temp.Length)        // 엔터 제거(엔터는 문자열 길이가 0이다)
                        {
                            --iCount;
                            //MessageBox.Show("엔터 구간이군");
                            continue;
                        }
                        if ('/' == Temp[0])          // 파일에 주석을 넣었을때 //를 만나면 무시하는 구문
                        {
                            --iCount;
                            //MessageBox.Show("주석처리 했니?");
                            continue;
                        }
                        if (XTile != Temp.Length)   // 가로 개수가 XTile만큼 없을때 오류 처리
                        {
                            //MessageBox.Show("한줄에 개수가 XTile이 아닌데요? XTile 개수 : " + Temp.Length.ToString());
                            break;
                        }
                        TempMap[iCount] = Temp;
                    }

                    // 여기까지왔으면 가로 한줄은 제대로 읽은것임
                    
                    if (YTile != iCount)         // 세로 개수가 YTile이 아닐때
                    {
                        MessageBox.Show("YTIle만큼의 배열이 없다 YTile개수 : " + iCount);
                        
                        while (true)
                        {
                            if (Temp == null)      // 파일 끝에 도달
                            {
                                break;
                                // 더 이상 읽기 불가
                            }
                            if (0 == Temp.Length)        // 엔터 확인
                            {
                                break;
                            }
                            Temp = MapFile.ReadLine();

                        }

                        if (Temp == null)      // 파일 끝에 도달
                        {
                            break;
                            // 더 이상 읽기 불가
                        }
                    }

                    else   // 맵을 잘 읽었으니까 맵카운트 ++
                    {
                        ++iMapCount;

                    }
                    
                }

                MapFile.Close();
                Map = aList.ToArray();
            }


            catch (FileNotFoundException)  // C# 고유기능으로, 인자를 넣지않아도 된다
            {
                MessageBox.Show("파일이 없다");
            }

            InternalMap();   // 내장된 맵 호출

            iFStage = Map.GetLength(0) - 1; // 지금 맵의 개수를 마지막 변수 iFStage에 저장
            iStage = 0;

            MapReal = new char[YTile][];

            LoadMap();
        }

        private void InternalMap()
        {
            Map = new string[][]    // YTile만큼의 배열 생성(세로)
           {
              new string[]
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

             new string[]
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
                },

             new string[]
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



        }

        private void LoadMap()
        {
            for (int i = 0; i < YTile; ++i)
            {
                MapReal[i] = Map[iStage][i].ToCharArray();
            }

        }

        private void MoveHuman()
        {

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
                            aBitmap = Human;
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
                            if ('.' != Map[iStage][iY][iX])  // 박스와 점이 겹치지않을때는 스테이지가 계속 유지
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            MapReal[HumanY][HumanX] = ' ';
            HumanXOld = HumanX;
            HumanYOld = HumanY;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Human = HumanL;
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
                    Human = HumanR;
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
                    Human = HumanFB;
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
                    Human = HumanFB;
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
            if ('.' == Map[iStage][HumanYOld][HumanXOld])   // 점의 위치에 있을때
            {
                MapReal[HumanYOld][HumanXOld] = '.';   // 원래 Map의 점의 위치일때를 복사해와서 점을 다시 그려준다
            }
            MapReal[HumanY][HumanX] = '@';

            Refresh();
            if (EndStage)  // EndStage가 true일때 스테이지 종료
            {
                if (iFStage == iStage)
                {
                    MessageBox.Show("게임이 끝났습니다");
                    Application.Exit();
                }
                MessageBox.Show("다음 스테이지로 이동합니다");
                ++iStage;   // 스테이지 변수 ++
                LoadMap();  // 변한 iStage에따라서 맵을 다시 그려줌

            }

            Invalidate();
            Refresh();
        }
    }
}
