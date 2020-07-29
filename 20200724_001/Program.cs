//메세지맵 기법
using System;
delegate int CalcDelegate(int x, int y);

class MessageMap    // 추가된 클래스
{
    public char opCode;
    public CalcDelegate Calc;
    public MessageMap(char opCode, CalcDelegate Calc)  // 생성자
    {
        this.opCode = opCode;
        this.Calc = Calc;
    }
}
public class Mathematics
{
    MessageMap[]    aMessageMap;
    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }
    static int Per(int x, int y) { return x % y; }   // 퍼센트 메서드 등록

    public Mathematics()    //  생성자
    {
        aMessageMap = new MessageMap[] {
            new MessageMap('+', Add),
            new MessageMap('-', Sub),
            new MessageMap('*', Mul),
            new MessageMap('/', Div),
            new MessageMap('%', Per)            // 퍼센트를 새로 추가
        };
    }

    // methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int Operand1, int Operand2)
    {
        Console.Write(opCode + " : ");
        foreach (MessageMap Temp in aMessageMap)  // 200개를 만들어도 이 foreach문은 바뀌지않지만, 스위치케이스문은 200개를 다 일일이 추가해줘야한다.
        {
            if(Temp.opCode == opCode) 
            { 
                Console.WriteLine(Temp.Calc(Operand1, Operand2));
            }
        }
    }
}

class Program
{
    // 3개의 매개변수를 받고 void를 반환하는 델리게이트 정의
    // 매개변수의 타입이 중요할 뿐 매개변수의 이름은 임의로 정할 수 있음.

    delegate void WorkDelegate(char arg1, int arg2, int arg3);

    static void Main(string[] args)
    {
        Mathematics math = new Mathematics();
        WorkDelegate work = math.Calculate;  // WorkDelegate를 호출하면 Calculate를 호출한다.
        work('+', 10, 6);
        work('-', 10, 6);
        work('*', 10, 6);
        work('/', 10, 6);
        work('%', 10, 6);
    }
}