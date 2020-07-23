using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_0052
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMenu;
           for(; ; )             // for( ; ;)는 무한반복임  while(true)도 무한반복임
            {
                Menu();
                Console.Write("메뉴를 입력하세요 : ");
                iMenu = int.Parse(Console.ReadLine());

                if (iMenu == 5) 
                {
                    break;
                }
                
            }
            
        }
        static void Menu()
        {
            Console.WriteLine("============================");
            Console.WriteLine("======계산기 프로그램=======");
            Console.WriteLine("=--------------------------=");
            Console.WriteLine("= 1. 덧셈                  =");
            Console.WriteLine("= 2. 뺄셈                  =");
            Console.WriteLine("= 3. 곱셈                  =");
            Console.WriteLine("= 4. 나눗셈                =");
            Console.WriteLine("= 5. 종료                  =");
            Console.WriteLine("============================");
        }
        static int Add(int iNum1, int iNum2)
        {
            int sum = iNum1 + iNum2;
            return sum;
        }

        }
}
