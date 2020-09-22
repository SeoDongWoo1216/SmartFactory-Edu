using System;
namespace _20200915_007_delegate2
{
    delegate int Facto(int i1, int i2); // 델리게이트 생성
   
    class Program
    {
        class MessageMap
        {
            public string cmd { get; set; }
            public Facto Method { get; set; }
            public MessageMap()
            {

            }
            public MessageMap(string _cmd, Facto _Method)
            {
                cmd = _cmd;
                Method = _Method;
            }
        }

        static public int Add(int T1, int T2)
        {
            return T1 + T2;
        }
        static public int Sub(int T1, int T2)
        {
            return T1 - T2;
        }
        static public int Mul(int T1, int T2)
        {
            return T1 * T2;
        }
        static public int Div(int T1, int T2)
        {
            return T1 / T2;
        }

        static int Step1(string command, int iNum1, int iNum2)
        {
            switch (command)
            {
                case "더하기":
                        return Add(iNum1, iNum2);
                case "빼기":
                        return Sub(iNum1, iNum2);
                case "곱하기":
                        return Mul(iNum1, iNum2);
                case "나누기":
                        return Div(iNum1, iNum2);
                default:
                    return 0;
            }
        }

        
        static int Step2(string command, int iNum1, int iNum2)
        {
            Facto aFacto;  // 델리게이트 변수선언
            switch (command)
            {
                case "더하기":
                    aFacto = Add;     // 델리게이트변수 aFacto를 add와 똑같이해줌
                    return aFacto(iNum1, iNum2);   // aFacto로 add를해서 반환
                case "빼기":
                    aFacto = Sub;
                    return aFacto(iNum1, iNum2);
                case "곱하기":
                    aFacto = Mul;
                    return aFacto(iNum1, iNum2);
                case "나누기":
                    aFacto = Div;
                    return aFacto(iNum1, iNum2);
                default:
                    return 0;
            }
        }
         
        // 메세지맵을 순환하면서 일치하는 것을 찾아서 가져오는 것.(cmd가 일치하는 것을 찾아서 Method를 불러오기)
        static int Step3(string command, int iNum1, int iNum2)
        {
            MessageMap[] aMessageMap = new MessageMap[]{
                new MessageMap() {cmd = "더하기", Method = Add },
                new MessageMap() {cmd = "빼기", Method = Sub },
                new MessageMap() {cmd = "곱하기", Method = Mul },
                new MessageMap() {cmd = "나누기", Method = Div },
            };
            foreach (var Temp in aMessageMap)
            {
                if(Temp.cmd.Equals(command)) // Equlas를 통해 ()안의 문자열과 똑같은지 bool형으로 반환해줌
                {
                    return Temp.Method(iNum1, iNum2);  // 조건문으로 찾은 Method를통해 연산한 값을 반환
                }
            }
            return 0;    // 스위치문의 디폴트값인 return 0; 을 해줌.
        }

        static int Step4(string command, int iNum1, int iNum2)
        {
            MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap("더하기", Add),
            new MessageMap("빼기", Sub),
            new MessageMap("곱하기", Mul),
            new MessageMap("나누기", Div)
        };
            foreach (var Temp in aMessageMap)
            {
                if (Temp.cmd.Equals(command)) // Equlas를 통해 ()안의 문자열과 똑같은지 bool형으로 반환해줌
                {
                    return Temp.Method(iNum1, iNum2);  // 조건문으로 찾은 Method를통해 연산한 값을 반환
                }
            }
            return 0;    // 스위치문의 디폴트값인 return 0; 을 해줌.
        }

     


        static void Main(string[] args)
        {
            // 입력받는 구문
            Console.Write("정수1을 입력하세요 : ");
            int iNum1 = int.Parse(Console.ReadLine());

            Console.Write("정수2를 입력하세요 : ");
            int iNum2 = int.Parse(Console.ReadLine());

            MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap("더하기", Add),
            new MessageMap("빼기", Sub),
            new MessageMap("곱하기", Mul),
            new MessageMap("나누기", Div)
        };

            string command;
            bool bingo = false;
            while (true)
            {
                Console.Write("수행할 연산을 한글로 입력하세요(도움말 : ?) : ");
                command = Console.ReadLine();
                if (null == command) // 스페이스바만 입력하고 엔터쳤을때
                {
                    Console.WriteLine("잘 못 입력하셨습니다");
                    continue;
                }
                else if("" == command) // 아무것도 입력안하고 엔터쳤을때
                {
                    Console.WriteLine("잘 못 입력하셨습니다");
                    continue;
                }

                if ('?' == command[0])
                {
                    Console.WriteLine("사용할 수 있는 연산 리스트");
                    Console.WriteLine("============================");
                    foreach (MessageMap Temp in aMessageMap)
                    {
                        Console.WriteLine(Temp.cmd);
                    }
                    Console.WriteLine("============================");
                    continue;
                }
                foreach (MessageMap Temp in aMessageMap)
                {
                    if (Temp.cmd.Equals(command)) // Equlas를 통해 ()안의 문자열과 똑같은지 bool형으로 반환해줌
                    {
                        bingo = true;
                    }
                }
                if (false == bingo)
                {
                    Console.WriteLine("잘못입력하셨습니다");
                    continue;
                }
                break;
            }

            // 계산, 출력하는 구문
            int Result = Step4(command, iNum1, iNum2);
            Console.WriteLine(command + $"의 결과는 {Result}입니다.");
        }
    }
}