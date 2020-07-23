using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_0051
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫번째 정수를 입력하세요 : ");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력하세요 : ");
            int inputNum2 = int.Parse(Console.ReadLine());
            Add(inputNum1, inputNum2);
            Sub(inputNum1, inputNum2);
            Mul(inputNum1, inputNum2);
            Div(inputNum1, inputNum2);
        }
        static int Add(int Add1, int Add2)
        {
            int a = Add1 + Add2;
            Console.WriteLine(a);
            return a;
        }
        static int Sub(int Sub1, int Sub2)
        {
            int b = Sub1 - Sub2;
            Console.WriteLine(b);
            return b;
        }
        static int Mul(int Mul1, int Mul2)
        {
            int c = Mul1 * Mul2;
            Console.WriteLine(c);
            return c;
        }
        static int Div(int Div1, int Div2)
        {
            int d = Div1 / Div2;
            Console.WriteLine(d);
            return d;
        }
    }
}
