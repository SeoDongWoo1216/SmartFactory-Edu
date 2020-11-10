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

namespace sokoban_014
{

    public partial class Form1 : Form
    {
        Bitmap HumanF;   // 휴먼(Human) = '@'
        Bitmap HumanB;
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
        int HumanX;
        int HumanY;
        int HumanXOld;  // 움직이기전 원래 좌표값을 백업할 변수
        int HumanYOld;

        int iStage;     // 지금의 스테이지가 몇인지 저장할 변수
        int iFStage;    // 마지막 스테이지를 저장할 변수
        int iMoveCount; // 움직일때마다 ++ 되는 변수
        int iTMoveCount;
        bool EndStage;  // 스테이지 끝날때, 안끝날때 bool형 변수


        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Right Display

        // 라벨 객체 생성
        Label lStageData = new Label();  // 값이 바뀌는 친구들은 따로 선언
        Label lTCountData = new Label();
        Label lCountData = new Label();

        // 버튼 객체 생성

        private void SetRinit()
        {
            SetRinitLabel();
            SetRinitLabelButton();
        }

        private void SetRinitLabelButton()
        {
            Font aFont = new Font("Courier New", 12);
            Button btnTemp = new Button();

            btnTemp.Size = new Size(50, 50);
            btnTemp.Location = new Point(XPixel * XTile + 75, 300);
            btnTemp.Font = aFont;
            //btnTemp.Text = "◀";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowLeft_Click);
            btnTemp.FlatAppearance.BorderSize = 0;
            btnTemp.FlatStyle = FlatStyle.Flat;
            btnTemp.TabStop = false;
            btnTemp.Image = Properties.Resources.ArrowLeft;
            Controls.Add(btnTemp);

            btnTemp = new Button();
            btnTemp.Size = new Size(50, 50);
            btnTemp.Location = new Point(XPixel * XTile + 175, 300);
            btnTemp.Font = aFont;
            //btnTemp.Text = "▶";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowRight_Click);
            btnTemp.TabStop = false;
            btnTemp.Image = Properties.Resources.ArrowRight;
            Controls.Add(btnTemp);

            btnTemp = new Button();
            btnTemp.Size = new Size(50, 50);
            btnTemp.Location = new Point(XPixel * XTile + 125, 250);
            btnTemp.Font = aFont;
            //btnTemp.Text = "▲";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowUp_Click);
            btnTemp.TabStop = false;
            btnTemp.Image = Properties.Resources.ArrowUp;
            Controls.Add(btnTemp);

            btnTemp = new Button();
            btnTemp.Size = new Size(50, 50);
            btnTemp.Location = new Point(XPixel * XTile + 125, 350);
            btnTemp.Font = aFont;
            //btnTemp.Text = "▼";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowDown_Click);
            btnTemp.TabStop = false;
            btnTemp.Image = Properties.Resources.ArrowDown;
            Controls.Add(btnTemp);

            btnTemp = new Button();
            btnTemp.Size = new Size(130, 30);
            btnTemp.Location = new Point(XPixel * XTile + 80, 170);
            btnTemp.Font = aFont;
            btnTemp.Text = "재시작";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowF5_Click);
            btnTemp.BackColor = Color.MediumPurple;
            btnTemp.FlatAppearance.BorderSize = 0;
            btnTemp.FlatStyle = FlatStyle.Flat;
            btnTemp.TabStop = false;
            Controls.Add(btnTemp);

            btnTemp = new Button();
            btnTemp.Size = new Size(130, 30);
            btnTemp.Location = new Point(XPixel * XTile + 80, 210);
            btnTemp.Font = aFont;
            btnTemp.Text = "다음 스테이지";
            btnTemp.TextAlign = ContentAlignment.MiddleCenter;
            btnTemp.Click += new System.EventHandler(btnArrowF6_Click);
            btnTemp.TabStop = false;
            Controls.Add(btnTemp);
        }

        private void SetRinitLabel()
        {
            Font aFont = new Font("Courier New", 12);  // 사용할 폰트 객체 생성
            Label lTemp;
            iTMoveCount = 0;      // 총 카운트는 처음에 0을 넣어줌

            // 1. 총 스테이지 출력
            lTemp = new Label();
            lTemp.Size = new Size(130, 20);
            lTemp.Location = new Point(XPixel * XTile + 30, 20);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringTitleTotalStage;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTemp);

            lTemp = new Label();
            lTemp.Size = new Size(50, 20);    // 그림판으로 그어보고 픽셀을 보면 대략적인 크기를 알 수 있다.  
            lTemp.Location = new Point(XPixel * XTile + 170, 20);
            lTemp.Font = aFont;
            lTemp.Text = (iFStage + 1).ToString();
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTemp);


            // 2. 현재 스테이지 출력
            lTemp = new Label();
            lTemp.Size = new Size(130, 20);
            lTemp.Location = new Point(XPixel * XTile + 30, 50);
            lTemp.Font = aFont;
            lTemp.Text = Properties.Resources.StringTitleStage;
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTemp);

            lStageData.Size = new Size(50, 20);
            lStageData.Location = new Point(XPixel * XTile + 170, 50);
            lStageData.Font = aFont;
            // text는 로드맵에 있음
            lStageData.BorderStyle = BorderStyle.Fixed3D;
            lStageData.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lStageData);


            // 3. 총 카운트 출력
            lTemp = new Label();
            iTMoveCount = 0;
            lTemp.Size = new Size(130, 20);
            lTemp.Location = new Point(XPixel * XTile + 30, 100);
            lTemp.Font = aFont;
            lTemp.Text = "Total Count";
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTemp);

            lTCountData.Size = new Size(50, 20);
            lTCountData.Location = new Point(XPixel * XTile + 170, 100);
            lTCountData.Font = aFont;
            lTCountData.Text = iTMoveCount.ToString();
            lTCountData.BorderStyle = BorderStyle.Fixed3D;
            lTCountData.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTCountData);


            // 4. 현재 카운트 출력
            lTemp = new Label();
            lTemp.Size = new Size(130, 20);
            lTemp.Location = new Point(XPixel * XTile + 30, 130);
            lTemp.Font = aFont;
            lTemp.Text = "Count";
            lTemp.BorderStyle = BorderStyle.Fixed3D;
            lTemp.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lTemp);

            lCountData.Size = new Size(50, 20);
            lCountData.Location = new Point(XPixel * XTile + 170, 130);
            lCountData.Font = aFont;
            // Text는 로드맵, 키다운 이벤트에있음
            lCountData.BorderStyle = BorderStyle.Fixed3D;
            lCountData.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(lCountData);


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        const int XPixel = 50;       // 게임화면 크기 변수
        const int YPixel = 50;
        const int XTile = 16;
        const int YTile = 10;
        const int XrDisplay = 300;   // 디스플레이 화면크기 변수
        public Form1()
        {
            InitializeComponent();
            Text = Properties.Resources.StringTitleGame;
            ClientSize = new Size(XPixel * XTile + XrDisplay, YPixel * YTile); // 클라이언트 폼 크기 설정 메서드

            Wall = new Bitmap(Properties.Resources.Wall);  // 이미지 할당은 생성자에서 이루어짐
            HumanF = new Bitmap(Properties.Resources.HumanF);
            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            Human = HumanF;
            Box = new Bitmap(Properties.Resources.Box);
            Point = new Bitmap(Properties.Resources.Point);
            Ground = new Bitmap(Properties.Resources.GND);
            Road = new Bitmap(Properties.Resources.Road);


            OpenMapFile();
            //InternalMap();


            iFStage = Map.GetLength(0) - 1; // 지금 맵의 개수를 마지막 변수 iFStage에 저장
            iStage = 0;

            MapReal = new char[YTile][];

            LoadMap();
            SetRinit();
        }

        private void OpenMapFile()
        {
            try
            {
                List<string[]> aList = new List<string[]>();
                StreamReader MapFile = new StreamReader(@"Map.txt");
                string Temp = null;
                string[] TempMap;
                int iCount;
                int iMapCount = 0;

                while (true)      // 주석 제거부
                {
                    Temp = MapFile.ReadLine();

                    if (Temp == null)             // 파일 끝에 도달했을때 Null이면 break;
                    {
                        throw new FileNotFoundException();
                    }

                    if (0 == Temp.Length)        // 엔터 검색(엔터 찾을때까지 계속 돈다)
                    {
                        break;
                    }
                }


                // 엔터 다음은 맵
                while (true)  // 전체 맵 로딩
                {
                    TempMap = new string[YTile];
                    for (iCount = 0; iCount < YTile; ++iCount)  // 맵 1개 로딩
                    {
                        Temp = MapFile.ReadLine();

                        if (Temp == null)             // 파일 끝에 도달
                        {
                            MessageBox.Show("맵 로드 중 파일 끝에 도달");
                            break;
                        }

                        if (XTile != Temp.Length)   // 가로 개수가 XTile만큼 없을때 오류 처리
                        {

                            //MessageBox.Show(+iCount + " 가로 개수 부족 : " + Temp.Length.ToString());
                            break;
                        }
                        TempMap[iCount] = Temp;
                    }

                    // 여기까지왔으면 가로 한줄은 제대로 읽은것임

                    if (YTile != iCount)         // 세로 개수가 YTile이 아닐때
                    {
                        //MessageBox.Show("파일 끝에 도달");

                        while (true)  // 다음 맵 검색
                        {
                            if (Temp == null)      // 파일 끝에 도달하면 종료
                            {
                                break;
                            }
                            if (0 == Temp.Length)        // 엔터 확인
                            {
                                break;
                            }
                            Temp = MapFile.ReadLine();

                        }

                        if (Temp == null)      // 파일 끝에 도달하면 종료
                        {
                            break;
                        }
                    }


                    // 맵 하나를 제대로 읽었을때 걸리는 else문
                    else
                    {
                        //++iMapCount;
                        aList.Add(TempMap);   // 맵 추가
                        while (true)          // 다음 맵 검색
                        {
                            Temp = MapFile.ReadLine();
                            if (null == Temp)   // 파일 끝에 도달하면 종료
                            {
                                break;
                            }
                            if (0 == Temp.Length)    // 엔터(맵 경계 발견)
                            {
                                break;
                            }
                        }

                    }
                    if (null == Temp)   // 파일 끝에 도달하면 종료
                    {
                        break;
                    }

                }

                MapFile.Close();
                if (0 == aList.Count)
                {
                    throw new FileNotFoundException();
                }
                //MessageBox.Show(aList.Count.ToString());
                Map = aList.ToArray();
            }


            catch (FileNotFoundException)
            {
                InternalMap();   // 내부맵 호출
                //MessageBox.Show("파일이 없다");
            }
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
              "G##     #   ###G", // 3
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
              "G##     ##   ##G", // 3
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
              "G##   ####   ##G", // 3
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
            lStageData.Text = (iStage + 1).ToString();
            iMoveCount = 0;                               // 새로운 맵을 출력하면 현재 카운트는 0으로 초기화
            lCountData.Text = iMoveCount.ToString();      // 카운트 라벨 출력
            lTCountData.Text = iTMoveCount.ToString();    // 총 카운트 라벨 출력
        }



        // 방향키 버튼 클릭 처리 이벤트
        private void btnArrowLeft_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.Left));
        }
        private void btnArrowRight_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.Right));
        }

        private void btnArrowDown_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.Down));
        }

        private void btnArrowUp_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.Up));
        }
        private void btnArrowF5_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.F5));
        }
        private void btnArrowF6_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(this, new KeyEventArgs(Keys.F6));
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            Form1_KeyDown(this, new KeyEventArgs(keyData));
            if ((Keys.Alt | Keys.F4) == keyData)   // &가 아니라 |로 처리해줘야한다.
            {
                Application.Exit();
            }

            //return base.ProcessCmdKey(ref msg, keyData); // 포커스를 다음 컴포넌트로 넘겨줌
            return true;  // 포커스를 넘겨주지않음
        }


        private void StageStart()
        {
            LoadMap();
            Refresh();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            lStageData.Focus();
            MapReal[HumanY][HumanX] = ' ';
            HumanXOld = HumanX;
            HumanYOld = HumanY;
            switch (e.KeyCode)
            {
                case Keys.F6:     // F6 눌렀을때 다음 스테이지 이동 처리
                    if (iFStage == iStage)
                    {
                        MessageBox.Show(Properties.Resources.StringQMsgNext, Properties.Resources.StringQMsgNextNoCap);
                        return;
                    }
                    Human = HumanF;
                    if (DialogResult.Cancel == MessageBox.Show(Properties.Resources.StringQMsgNextWhat,    // 메세지박스 버튼 '취소'를 클릭했을때
                                                               Properties.Resources.StringQMsgNextWhatCap,
                                                               MessageBoxButtons.OKCancel))
                    {
                        return;
                    }
                    ++iStage;
                    StageStart();
                    return;

                case Keys.F5:       // F5 눌렀을때 재시작 처리
                    Human = HumanF;
                    if (DialogResult.Cancel == MessageBox.Show(Properties.Resources.StringQMsgRestart,    // 메세지박스 버튼 '취소'를 클릭했을때
                                                               Properties.Resources.StringQMsgRestartCap,
                                                               MessageBoxButtons.OKCancel))
                    { 
                        return;
                    }

                    StageStart();
                    return;


                case Keys.Left:
                    Human = HumanL;
                    if ('#' == MapReal[HumanY][HumanX - 1])    // 사람의 왼쪽이 벽이면 return
                    {
                        break;
                    }
                    if ('B' == MapReal[HumanY][HumanX - 1])   // 사람 왼쪽에 박스가 있으면 박스의 위치를 한칸 더 왼쪽에 그려줌(박스 들고 이동되는것처럼 보임)
                    {
                        if ('#' == MapReal[HumanY][HumanX - 2])
                        {
                            break;
                        }
                        if ('B' == MapReal[HumanY][HumanX - 2])  // 박스 2개가 겹칠때 못움직이도록
                        {
                            break;
                        }
                        MapReal[HumanY][HumanX - 2] = 'B';
                    }

                    --HumanX;
                    break;


                case Keys.Right:
                    Human = HumanR;
                    if ('#' == MapReal[HumanY][HumanX + 1])
                    {
                        break;
                    }

                    if ('B' == MapReal[HumanY][HumanX + 1])
                    {
                        if ('#' == MapReal[HumanY][HumanX + 2])
                        {
                            break;
                        }
                        if ('B' == MapReal[HumanY][HumanX + 2])
                        {
                            break;
                        }
                        MapReal[HumanY][HumanX + 2] = 'B';

                    }
                    ++HumanX;
                    break;


                case Keys.Up:
                    Human = HumanB;
                    if ('#' == MapReal[HumanY - 1][HumanX])
                    {
                        break;
                    }
                    if ('B' == MapReal[HumanY - 1][HumanX])
                    {
                        if ('#' == MapReal[HumanY - 2][HumanX])
                        {
                            break;
                        }
                        if ('B' == MapReal[HumanY - 2][HumanX])
                        {
                            break;
                        }
                        MapReal[HumanY - 2][HumanX] = 'B';
                    }
                    --HumanY;
                    break;


                case Keys.Down:
                    Human = HumanF;
                    if ('#' == MapReal[HumanY + 1][HumanX])
                    {
                        break;
                    }

                    if ('B' == MapReal[HumanY + 1][HumanX])
                    {
                        if ('#' == MapReal[HumanY + 2][HumanX])
                        {
                            break;
                        }
                        if ('B' == MapReal[HumanY + 2][HumanX])
                        {
                            break;
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

            if ((HumanY != HumanYOld) || (HumanX != HumanXOld))   // 벽, 상자에 부딪혔을때 움직여도 카운트 안되도록 조건문걸어줌
            {
                ++iMoveCount;
                lCountData.Text = iMoveCount.ToString();
                lTCountData.Text = (iMoveCount + iTMoveCount).ToString();
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
                    MessageBox.Show(Properties.Resources.StringMsgFinalStage);
                    Application.Exit();
                }
                MessageBox.Show(Properties.Resources.StringMsgNextStage);
                ++iStage;   // 스테이지 변수 ++
                iTMoveCount = iTMoveCount + iMoveCount;
                //lTCountData.Text = (iTMoveCount + iMoveCount).ToString(); 
                LoadMap();  // 변한 iStage에따라서 맵을 다시 그려줌

            }

            Invalidate();
            Refresh();
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
    }
}
