using System;
class FACT<T1, T2>
{
    public T1 Value1;
    public T2 Value2;
    public void Print()
    {
        Console.WriteLine("FACT Value = {0}, {1}", Value1, Value2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        FACT<int, string> obj = new FACT<int, string>();
        obj.Value1 = 100;
        obj.Value2 = "서맛트 팩토리";
        obj.Print();
    }
}