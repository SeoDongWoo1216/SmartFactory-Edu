using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_TEST1
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
            Console.WriteLine("과정명 : 스마트팩토리 과정");
            Console.WriteLine("교과목 : C# 기초");
            Console.WriteLine("응시일 : 2020.05.26");
            Console.WriteLine("응시자 : 서동우");
            int a;
            int b;
            for(a=2;a<100;a++)
            {
                b = 2;
                while (b < a)
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
