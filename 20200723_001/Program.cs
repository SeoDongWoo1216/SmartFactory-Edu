using System;

class Program
{
    delegate int Calculator(int Num1, int Num2);
    static int Add(int Num1, int Num2)
    {
        return Num1 + Num2;
    }

    static int Div(int Num1, int Num2)
    {
        return Num1 / Num2;
    }

    static  int Sub(int Num1, int Num2)
    {
        return Num1 - Num2;
    }

    static public int Mul(int Num1, int Num2)
    {
        return Num1 * Num2;
    }
    static void Main(string[] args)
    {
        int iResult;
        Calculator[] aCalculator = new Calculator[] { Add, Sub, Mul, Div };
        for(int i = 0; i<aCalculator.Length; ++i)
        {
            iResult = aCalculator[i](3, 4);
            Console.WriteLine(iResult);
        }
        Console.WriteLine();

        //for문을 foreach문으로 바꿔보자
        foreach (Calculator i in aCalculator)
        {
            iResult = i(3, 4);
            Console.WriteLine(iResult);
        }
    }
}

/*
 

        //iResult = Add(3, 4);
        //Console.WriteLine(iResult);
        //iResult = Sub(3, 4);
        //Console.WriteLine(iResult);
        //iResult = Mul(3, 4);
        //Console.WriteLine(iResult);
        //iResult = Div(3, 4);
        //Console.WriteLine(iResult);
 */
