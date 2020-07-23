using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200713_002
{
    public partial class Form1 : Form
    {
        const int WTileSize = 16;
        const int HTileSize = 9;
        const string Title = "푸시푸시 [Stage : ";

        int Stage;
        bool EndGame;
        int keyCount;

        Image Human;
        Image HumanF;
        Image HumanB;
        Image HumanL;
        Image HumanR;

        Image Wall;
        Image Road;
        Image Box;
        Image Dot;

        int WTile;  // 가로 타일
        int HTile;  // 세로 타일

        int XHuman;
        int YHuman;
        int XHumanOld;
        int YHumanOld;
        
        char[][] MapReal;

        string[,] Map = {   
                                 { "################",  // 0
                                   "##            ##",  // 1
                                   "##    ## #  ####",  // 2
                                   "## #  ## # #####",  // 3
                                   "##    ## #  ####",  // 4
                                   "### ####    ####",  // 5
                                   "###     B.  ####",  // 6
                                   "###   @ B.  ####",  // 7
                                   "################"   // 8
                                },
                                {  
                                 "################",  // 0
                                 "##         ...##",  // 1
                                 "##    ## #  ####",  // 2
                                 "## #  ## # #####",  // 3
                                 "##    ## #  ####",  // 4
                                 "### #### #  ####",  // 5
                                 "### B  B  B ####",  // 6
                                 "###  @      ####",  // 7
                                 "################"   // 8
                                }
                                };

        
       

        public Form1()
        {
            InitializeComponent();
           
            Text = Title;
            Stage = 0;

            HumanF = new Bitmap(Properties.Resources.HumanF);
            WTile = HumanF.Width;   // 이미지의 가로, 세로의 크기를 추출(48px)
            HTile = HumanF.Height;  // 이 두줄덕분에 크기가 바껴도 코드를 크게 수정하지않아도된다
            ClientSize = new Size(WTileSize * WTile, HTileSize * HTile);
            // ClientSize가 타입이 Size형이니까 Size의 크기를 ()안에 적어준다.
            // ClientSize를 치고 컨트롤을 누른상태로 ClientSize를 눌러준다.
            // 이런 키워드를 추적해서 using System의 형태를 알아줘야한다.

            HumanB = new Bitmap(Properties.Resources.HumanB);
            HumanL = new Bitmap(Properties.Resources.HumanL);
            HumanR = new Bitmap(Properties.Resources.HumanR);

            Wall = new Bitmap(Properties.Resources.Wall);
            Road = new Bitmap(Properties.Resources.Road);
            Box = new Bitmap(Properties.Resources.Box);
            Dot = new Bitmap(Properties.Resources.Dot);

            XHuman = 0;
            YHuman = 0;

            LoadMap();
        }

        private void LoadMap()
        {
            //판을 바꾸는 코드
            MapReal = new char[HTileSize][];    // 2차원 배열생성을 위해 객체생성
            for (int i = 0; i < HTileSize; ++i)  // 줄 수만큼 반복해서 1차원배열을 반복해서 2차원으로 한다.
            {
                MapReal[i] = Map[Stage, i].ToCharArray();
            }
            keyCount = 0;  // 판이 넘어갈때 키 누른 횟수를 0으로 초기화
            Human = HumanF;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            EndGame = true;  // true일때 게임의 종료 조건
            Image Temp=Wall;
            for (int j = 0; j<HTileSize; ++j)
            {
                for (int i = 0; i < WTileSize; ++i)
                {
                    switch (MapReal[j][i]) {  // 각 문자에 해당되는 이미지를 출력하는 스위치문 ex) #이면 Wall 이미지 출력
                        case '#':
                            Temp = Wall;
                            break;
                        case 'B':
                            Temp = Box;
                            if ('.' != Map[Stage, j][i])   // 박스가 점에갔을때 종료하는 조건문
                            {
                                EndGame = false;
                            }
                            break;
                        case '.':
                            Temp = Dot;
                            break;
                        case ' ':
                            Temp = Road;
                            break;
                        case '@':       // 3. @의 위치를 아는 코드이기때문에 캐릭터를 움직이는 것의 힌트가 된다.
                            Temp = Human;
                            XHuman = i;
                            YHuman = j;
                            break;
                    }
                    e.Graphics.DrawImage(Temp, WTile * i, HTile * j);
                }
            }
            Text = Title + (Stage+1) +  "]  [" + keyCount + "]";   // 키로 이동할때마다 제목에 카운트해주는 구문
        }

        private void Move()  // 키를 눌렀을때 움직이는 구문을 이 메서드에 작성
        {
            if ('#' == MapReal[YHuman][XHuman])  // 벽에 부딪히면 막히게해줌.
            {
                return;
            }
            else if ('B' == MapReal[YHuman][XHuman])  // 캐릭터가 박스를 만나면 한칸 미는것
            {
                if('#' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld]) // 상자가 벽에 부딪혔을때 안움직이게하는코드
                {
                    return;
                }
                if ('B' == MapReal[YHuman * 2 - YHumanOld][XHuman * 2 - XHumanOld]) // 상자가 2개가 겹쳤을때 안움직이게하는코드
                {
                    return;   // return이 들어가면 이미 분리된거나 다름없기때문에 else if를 굳이 붙이지않아도된다.(else if랑 똑같다)
                }
                MapReal[YHuman*2 - YHumanOld][XHuman*2 - XHumanOld] = 'B'; // 좌항은 좌표를뜻함. 박스가 캐릭터를만나면 이동되는 코드
            }
            

            // 상자나 캐릭터가 점위에있을때 다시 점이 출력되도록하는 조건문(캐릭터가 점에서 벗어났을때 점이 다시 출력)
            if('.' == Map[Stage, YHumanOld][XHumanOld])    // Map은 수정이 안된 맵
            { 
                MapReal[YHumanOld][XHumanOld] = '.';    // MapReal은 계속 변하고있는 맵(@가 움직이고있을때의 맵)
            }
            else
            {
                MapReal[YHumanOld][XHumanOld] = ' ';
            }
            MapReal[YHuman][XHuman] = '@'; // 박스가 있던 자리에 캐릭터가 들어가는 코드

            ++keyCount;  // 이게 맨위에있으면 안움직였을때도 카운트되니까 구문 맨 마지막에 있는게 좋다.

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)   // 키보드 방향키 눌렀을때의 이벤트
        {
            YHumanOld = YHuman;
            XHumanOld = XHuman;
            // 맞는 곳으로 바로 점프하는 스위치문이 if문보다 더 효율적이다.
            switch (e.KeyCode)
            {
                case Keys.F5:        // 게임조졌을때 재시작해주는 버튼
                    if (DialogResult.Yes == MessageBox.Show("다시 시작할까요?", "선택", MessageBoxButtons.YesNo))
                    {
                        LoadMap();
                    }
                    return;   // 더 이상 처리하지않으니 break가아닌 return을 써준다.
                case Keys.Left:
                    --XHuman;   // 배열을 움직이는 것으로 밑의 코드에서 이 코드로 바꿈
                    Human = HumanL;
                    break;
                case Keys.Right:
                    ++XHuman;
                    Human = HumanR;
                    break;
                case Keys.Up:
                    --YHuman;
                    Human = HumanB;
                    break;
                case Keys.Down:
                    ++YHuman;
                    Human = HumanF;
                    break;
                default:              // 우리가 입력하는거 말고 기타 등등
                    return;  
            }
            Move();
            Refresh();  // 화면을 다시 그리는 메서드
            if (EndGame == true)  //게임이 종료될때 메세지박스 출력
            {
                ++Stage;
                if (Stage == Map.Length/HTileSize)   // 맵의 개수(Length)가 Stage와 똑같아졌을때 게임 종료출력
                {
                    MessageBox.Show("게임을 종료합니다", "알림", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
                MessageBox.Show("다음판으로 이동합니다", "알림", MessageBoxButtons.OK);
                LoadMap();
                
            }

        }
    }
}

// 장애물, 복도도 만들어야하는데 좌표값으로 계산해서 만들면 머리털이 다 빠지게된다.
// 그래서 매핑을 사용해서 만들예정. 배열을 만들어서 표현해볼예정. 
// 배열의 이름은 맵, 벽 : '#' , 휴먼 : '@' , 길 : ' ', 박스 : 'B', 도착지(점) : '.'