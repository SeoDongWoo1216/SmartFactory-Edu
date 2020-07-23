using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200522_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("───── 47p 불형 예제 ─────");
            bool isNumeric = false;
            bool isNumeric2 = 7 > 6;  // 대입연산자는 비교순위가 낮음(비교먼저함)

            Console.WriteLine(isNumeric);
            Console.WriteLine(isNumeric2);
            Console.WriteLine("\n");

            Console.WriteLine("───── 49p 암시적변환 예제 ─────");
            byte b = 250;
            short s = b;
            Console.WriteLine(s);
            Console.WriteLine("\n");

            Console.WriteLine("───── 49p 명시적변환 예제 ─────");
            ushort u = 65;
            char c = (char)u;
            Console.WriteLine(c);
            Console.WriteLine("\n");

            Console.WriteLine("───── 50p 불형 예제 ─────");
            int n = 40000;
            short s1 = (short)n;
            Console.WriteLine(s1);  // 
            Console.WriteLine("\n"); 
        }
    }
}
