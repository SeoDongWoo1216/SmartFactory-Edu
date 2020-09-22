using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("시험점수 입력 : ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 90 && n <= 100)
            Console.WriteLine("A");
        else if (n >= 80 && n < 90)
            Console.WriteLine("B");
        else if (n >= 70 && n<80)
            Console.WriteLine("C");
        else if (n >= 60 && n<70)
            Console.WriteLine("D");
        else
            Console.WriteLine("F");
    }
}



