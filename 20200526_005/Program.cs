using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_005
{
    class Program
    {
        static void Main(string[] args)
        { 
            int iNum1 = Add(10, 20);
            Console.WriteLine("덧셈 : {0} ", iNum1);
            int iNum2 = Sub(10, 20);
            Console.WriteLine("뺄셈 : {0} ", iNum2);
            int iNum3 = Mul(10, 20);
            Console.WriteLine("곱셈 : {0} ", iNum3);
            int iNum4 = Div(10, 20);
            Console.WriteLine("나눗셈 : {0} ", iNum4);
        }
        static int Add (int Add1, int Add2)
        {
            return Add1 + Add2;
        }
        static int Sub(int Sub1, int Sub2)
        {
            return Sub1 - Sub2;
        }
        static int Mul(int Mul1, int Mul2)
        {
            return Mul1 * Mul2;
        }
        static int Div(int Div1, int Div2)
        {
            return Div1 / Div2;
        }
    }
}
