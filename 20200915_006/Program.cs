using System;
class Program
{
    static int mulInt(int Temp1, int Temp2)
    {
        return Temp1 * Temp2;
    }
    static int addInt(int Num1, int Num2)
    {
        return Num1 + Num2;
    }
    delegate int Facto(int Num1, int Num2);
    static void Main(string[] args)
    {
        int sum = addInt(3, 4);
        Console.WriteLine(sum);

        Facto aFacto;
        aFacto = addInt;
        sum = aFacto(3, 4);
        Console.WriteLine(sum);

        aFacto = mulInt;
        sum = aFacto(3, 4);
        Console.WriteLine(sum);
    }
}