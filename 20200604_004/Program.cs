using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_004
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);
        static void Add(int x, int y) 
        { 
            Console.WriteLine(x + y); 
        }
        static void Subtract(int x, int y) 
        { 
            Console.WriteLine(x - y); 
        }
        static void Multiply(int x, int y) 
        {
            Console.WriteLine(x * y); 
        }
        static void Divide(int x, int y) 
        { 
            Console.WriteLine(x / y); 
        }

        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Subtract;   // calc = calc + Subtract
            calc += Multiply;
            calc += Divide;

            calc(10, 5); // add, sub, mul, div 메서드 모두 호출

            calc -= Multiply;  // 목록에서 Multiply 메서드를 제거
            calc(10,5);  // add, sub, div 메서드만 호출
        }
    }
}
