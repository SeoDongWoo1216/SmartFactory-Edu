using System;
public class Mathematics
{
    delegate int CalcDelegate(int x, int y);
    static int Add(int x, int y) { return x + y; }
    static int Sub(int x, int y) { return x - y; }
    static int Mul(int x, int y) { return x * y; }
    static int Div(int x, int y) { return x / y; }

    CalcDelegate[] method;
    
    
    public Mathematics()
    {
        //static 메서드를 가리키는 델리게이트 배열 초기화
        method = new CalcDelegate[] { Mathematics.Add, Mathematics.Sub, Mathematics.Mul, Mathematics.Div };
    }


    // methods 배열에 담긴 델리게이트를 opCode 인자에 따라 호출
    public void Calculate(char opCode, int Operand1, int Operand2)
    {
        Console.Write(opCode + " : ");
        switch (opCode)
        {
            case '+':
                Console.WriteLine(method[0](Operand1, Operand2));
                break;
            case '-':
                Console.WriteLine(method[1](Operand1, Operand2));
                break;
            case '*':
                Console.WriteLine(method[2](Operand1, Operand2));
                break;
            case '/':
                Console.WriteLine(method[3](Operand1, Operand2));
                break;
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
        work('+', 10, 5);
        work('-', 10, 5);
        work('*', 10, 5);
        work('/', 10, 5);
    }
}