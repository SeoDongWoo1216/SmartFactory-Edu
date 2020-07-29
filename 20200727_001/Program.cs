using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    static extern int MessageBeep(uint uType);

    static int TestMethod(uint type) // 비교를 위한 정적 메서드
    {
        return 0;
    }
    static void Main(string[] args)
    {
        MessageBeep(0);
    } 
}


//        using System;
//class Program
//{

//    static void Main(string[] args)
//    {
//        PrintAll(1.05, "Result", 3);
//    }
//    private static void PrintAll(params object[] values)
//    {
//        foreach (object value in values)
//        {
//            Console.WriteLine(value);
//        }
//    }

//    //static void Main(string[] args)
//    //{
//    //    Console.WriteLine(Add(1,2,3,4,5));
//    //    Console.WriteLine(Add(1, 2, 3, 4, 5,6,7,8,9,10));
//    //}

//    //static int Add(params int[] values)
//    //{
//    //    int result = 0;

//    //    for(int i=0; i<values.Length; i++)
//    //    {
//    //        result += values[i];
//    //    }

//    //    return result;
//    //}
//}


