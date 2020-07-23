using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_TEST2
{
    /*
1. 2부터 100까지 정수에서 소수를 구하는 프로그램을 작성하여 결과를 제출하시오
2. 실행시 첫 4줄은 그림을 참고하여 작성하시오
3. 중복 반복문을 이용하여 작성하시오
   */
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            for(a=2; a<100;a++)
            {
                b = 2;
                while(a>b)
                {
                    if (a % b == 0)
                    {
                        break;
                    }
                    else
                    {
                        b++;
                    }
                }

                if (a == b)
                {
                    Console.Write(" {0} ", a);
                }
            }
            Console.WriteLine();
        }
    }
}
