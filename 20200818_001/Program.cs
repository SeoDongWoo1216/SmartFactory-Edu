using System;

class Program
{
    static void ArrayIntPrint(int[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
        //foreach (int Temp in Num)
        //{
        //    Console.WriteLine("{0}", Temp);
        //}
    }

    static void ArraydoublePrint(double[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
    }

    static void ArrayStringPrint(String[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0} ", Num[Temp]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] Numbers1 = {1,3,5,7,9 };
        ArrayIntPrint(Numbers1);
        Console.WriteLine();
        
        double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };  // float형은 f를 붙여야하고, 그냥 실수면 double형이다.
        ArraydoublePrint(Numbers2);
        Console.WriteLine();

        string[] Numbers3 = { "일","이","삼","사"};  // 문자열은 ""를 붙여줘야한다.
        ArrayStringPrint(Numbers3);
        Console.WriteLine();

    }
}

