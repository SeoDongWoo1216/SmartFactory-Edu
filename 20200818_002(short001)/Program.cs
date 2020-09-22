using System;
class Program
{
    static void ArrayPrint<T>(T[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
            Console.Write("{0}  ", Num[Temp]);
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] Numbers1 = { 1, 3, 5, 7, 9 };
        double[] Numbers2 = { 1.1, 3.1, 5.1, 7.1, 9.1 };  // float형은 f를 붙여야하고, 그냥 실수면 double형이다.
        string[] Numbers3 = { "일", "이", "삼", "사" };  // 문자열은 ""를 붙여줘야한다.
        ArrayPrint<int>(Numbers1);
        ArrayPrint<double>(Numbers2);
        ArrayPrint<string>(Numbers3);
    }
}

