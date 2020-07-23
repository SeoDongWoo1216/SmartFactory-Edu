using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200528_002
{
    class Mathematics
    {
        public void PrintIfEven(int value)
        {
            if(value % 2 == 0)
            {
                Console.WriteLine(value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            int x = 5;
            m.PrintIfEven(x);
            x = 10;
            m.PrintIfEven(x);
        }             
    }    // 출력 결과 : 10
}
