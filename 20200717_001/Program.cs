using System;
class Program
{
    static void Main(string[] args)
    {
        int Num1;
        int Num2;
        double Num3;

        while (true)
        {
            try
            {
                Console.Write("첫번째 양수 : ");
                Num1 = int.Parse(Console.ReadLine());
                if (Num1 < 0)
                {
                    Exception aException = new Exception();  // 예외객체를 프로그래머가 직접 만들수도있다
                    throw aException;  // 여기서 Exception으로 던져준다.
                }
                Console.Write("두번째 양수 : ");
                Num2 = int.Parse(Console.ReadLine());
                if (Num2 < 0)
                {
                    Exception aException = new Exception();  // 예외객체를 프로그래머가 직접 만들수도있다
                    throw aException;  // 여기서 Exception으로 던져준다.
                }

                Num3 = Num1 / Num2;
            }

            // 컴파일 오류가나면 닷넷이 잡아주는데, catch로 해두면 프로그래머가 발생한것을 대비했다고 간주해서 닷넷이 손을뗀다.
            // continue를 입력하면 제대로 입력할때까지 이 루프를 빠져나갈 수 없다.
            catch (FormatException e)
            {
                // Console.WriteLine(e.ToString() +"\n"); // e 출력하면 오류메세지자체가 들어있다.
                Console.WriteLine("\n문자를 입력했습니다.");
                continue;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n0으로 나눴습니다.");
                continue;
            }
            catch (Exception)    // catch의 Execption은 모든 예외처리를 아우르기 때문에 맨 밑에 둬야한다.
            {
                Console.WriteLine("\n음수를 입력했습니다.");
                continue;
            }
            finally
            {
                Console.WriteLine("파이널리는 오류가 뜨든 성공하든 무조건 거쳐간다.\n");
                // 오류가뜨든 말든 실행해야하는 코드는 파이널리에 적어두는게 좋다.
            }
            break;
        }
    }
}


//Console.Write("첫번째로 입력할 숫자 : ");
//        //Num1 = 100;   // 이거는 하드코딩(항상 100만 들어감)
//        //int.Parse("100") 문자열 100을 int형 100으로 바꿔준다
            
//        Num1 = int.Parse(Console.ReadLine()); // 키보드로 입력받음. ReadLine은 string타입으로 문자형을받는다
//                                              // 밑의 3줄을 위의 코드 1줄 표현하면된다.

////string TempString;
////TempString = Console.ReadLine();
////Num1 = int.Parse(TempString); 


//Console.Write("두번째로 입력할 숫자 : ");
//        Num2 = int.Parse(Console.ReadLine()); // 키보드로 입력받음. ReadLine은 string타입으로 문자형을받는다

//Console.WriteLine("첫번째 숫자 : " + Num1);
//        Console.WriteLine("두번째 숫자 : " + Num2);