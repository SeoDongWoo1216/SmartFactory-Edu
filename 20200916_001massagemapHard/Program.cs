using System;

namespace _20200916_001massagemapHard
{
    delegate int Facto(int i1, int i2); // 델리게이트 생성

    class Program
    {
        static MessageMap[] aMessageMap = new MessageMap[] {
            new MessageMap("더하기", Add),
            new MessageMap("빼기", Sub),
            new MessageMap("곱하기", Mul),
            new MessageMap("나누기", Div),
            new MessageMap("거듭제곱", Square)
        };
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
        static public int Square(int T1, int T2)
        {
            int Temp = 1;
           while(0 != T2)
            {
                Temp = Temp * T1;
                --T2;
            }
            return Temp;
        }


        // 찾는 역할인 SearchDelegate 메서드선언
        static Facto SearchDelegate(string command)
        {
            foreach (var Temp in aMessageMap)
            {
                if (Temp.cmd.Equals(command)) 
                {
                    return Temp.Method;  
                }
            }
            return null;    // 스위치문의 디폴트값인 return 0; 을 해줌.
        }

        // 연산실행하는 구문
        static int RunCaCul(string command, int iNum1, int iNum2)
        {
            Facto aFacto = SearchDelegate(command);
            if(null == aFacto)
            {
                return 0;
            }
            return aFacto(iNum1, iNum2);
            
        }

        // 명령어 리스트 출력하는 메서드(보통 메뉴를 출력할때 사용)
        static void CmdList()
        {
            Console.WriteLine("사용할 수 있는 연산 리스트");
            Console.WriteLine("============================");
            foreach (MessageMap Temp in aMessageMap)
            {
                Console.WriteLine(Temp.cmd);
            }
            Console.WriteLine("============================");    
        }

       // 명령어 처리할때 이상한거를 입력하면 루프를 돌려서 제대로 입력할때까지 출력한다
        static string InputCmd()
        {
            string command;

            while (true)
            {
                Console.Write("수행할 연산을 한글로 입력하세요(도움말 : ?) : ");
                command = Console.ReadLine();

                if ("" == command) // 아무것도 입력안하고 엔터쳤을때
                {
                    Console.WriteLine("잘 못 입력하셨습니다(공백을 입력하셨습니다)");
                    continue;
                }

                if ('?' == command[0]) // 배열 첫번째자리에 ?를 입력하면 명령어 리스트 출력
                {
                    CmdList();
                    continue;
                }

                foreach (MessageMap Temp in aMessageMap) // 제대로된 명령어가 있는지 반복문으로 찾기
                {
                    if (Temp.cmd.Equals(command)) // Equlas를 통해 ()안의 문자열과 똑같은지 bool형으로 반환해줌
                    {
                        return command;   // 제대로된 명령어가 조건문에 걸려서 왔으니까 그대로 출력
                    }
                }
                    Console.WriteLine("잘 못 입력하셨습니다"); // 못찾았으니 잘못입력했다고 출력되고 while문이므로 다시 루프가 돈다

            }
        }


        static void Main(string[] args)
        {
            // 입력받는 구문
            Console.Write("정수1을 입력하세요 : ");
            int iNum1 = int.Parse(Console.ReadLine());

            Console.Write("정수2를 입력하세요 : ");
            int iNum2 = int.Parse(Console.ReadLine());

            string command = InputCmd();  // 입력받은 command가 맞게 입력됬는지 확인하고 출력해줌

            // 계산, 출력하는 구문
            int Result = RunCaCul(command, iNum1, iNum2);

            Console.WriteLine(command + $"의 결과는 {Result}입니다.");
        }
    }
}
