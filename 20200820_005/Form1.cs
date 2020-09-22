using System;
using System.Windows.Forms;
namespace _20200820_005
{
    public partial class Form1 : Form
    {
        int[] intArray;
        int score;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void Init()
        {
            Random aRandom = new Random();
            intArray = new int[3] { 100, 100, 100 };  // new로 생성했으니까 0으로 채워져있는 배열에 값 대입

            for (int Count = 0; Count < intArray.Length; ++Count) // Count : 랜덤 숫자를 저장할 곳
            {
                int iTemp = aRandom.Next(0, 10);
                int Count2 = 0;
                for (Count2 = 0; Count2 < intArray.Length; ++Count2)  // Count2 : 생성된 랜덤 숫자가 겹치는지 비교하는 곳
                                                                      //Count2가 3(intArray.Legnth)이되면 중복된 숫자없이 잘 돌았다는 얘기이다.
                {
                    if (iTemp == intArray[Count2]) // 생성된 랜덤 숫자가 겹치면
                    {
                        break;
                    }
                }
                if (Count2 < intArray.Length) //Count2가 3보다 작으면 랜덤 숫자가 겹쳤다는 얘기.
                                              // 숫자가 겹쳤을때 수행하는 if문
                {
                    --Count; // 숫자가 겹쳤으므로 최상위 for문의 Count가 다시 -되서 돌아온다.
                    continue; // continue를 통해 최상위 반복문으로 빠져나간다.
                }
                intArray[Count] = iTemp;   // 안겹쳤으면 랜덤 숫자를 대입해준다!
            }
            lbRand1.Text = intArray[0].ToString();
            lbRand2.Text = intArray[1].ToString();
            lbRand3.Text = intArray[2].ToString();

            score = 0;
            lbCount.Text = score.ToString(); // 게임 횟수를 돌린만큼 카운트
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int strikeCount = 0;
            int ballCount = 0;

            int[] InputArray = new int[intArray.Length];  // 하드코딩 방지를위해 배열의 개수를 intArray.Length로 해주자(3을 적어도된다)
            InputArray[0] = Convert.ToInt32(txtInput1.Text);
            InputArray[1] = Convert.ToInt32(txtInput2.Text);
            InputArray[2] = Convert.ToInt32(txtInput3.Text);

            for (int Count1 = 0; Count1 < intArray.Length; ++Count1) 
            {
                for (int Count2 = 0; Count2 < intArray.Length; ++Count2)
                {
                    if (InputArray[Count1] == intArray[Count2])    // 숫자비교
                    {
                        if (Count1 == Count2)   // 위치 비교 : 첫번째 자리와 입력한 첫번째 숫자가 같으면 스트라이크
                        {
                            ++strikeCount;  // 스트라이크가 발견되면 카운트 증가
                        }
                        else // 위치가 다른데 숫자가 같으면 볼
                        {
                            ++ballCount;   // 볼이 발견되면 카운트 증가
                        }
                        break; // 스트라이크나 볼을 찾았으면 빠져나와야한다.(중복되는 숫자는 없으니까)
                    }
                }
            }
            if (strikeCount == 0 && ballCount == 0)  // 숫자가 겹치는게 없을때는 아웃
            {
                lbBall.Text = "";
                lbStrike.Text = "";
                lbOut.Text = "O";
            }
            else
            {
                lbStrike.Text = strikeCount.ToString(); // 스트라이크, 볼의 개수를 라벨에 표시해준다.
                lbBall.Text = ballCount.ToString(); // 왼쪽은 라벨, 오른쪽은 int정수이기때문에 각각 텍스트, 글자로 바꿔준다.
                ++score;
                lbCount.Text = score.ToString();
                lbOut.Text = "";
            }
        }

        //리셋 버튼 이벤트
        private void button2_Click(object sender, EventArgs e)
        {
            Init();
            lbStrike.Text = ""; // 스트라이크, 볼의 개수도 0으로 리셋시켜주는 것처럼 보이게하는 구문
            lbBall.Text = "";
            lbOut.Text = "";
            txtInput1.Clear();
            txtInput2.Clear();
            txtInput3.Clear();
        }
    }
}