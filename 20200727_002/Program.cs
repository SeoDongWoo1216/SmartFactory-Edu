// unsafe 예제
using System;
class Program
{
    static void Main(string[] args)
    {
        int iNum = 100;
        unsafe 
        { 
        Console.WriteLine("{0:X}", (int)&iNum);
        }
    }
}
