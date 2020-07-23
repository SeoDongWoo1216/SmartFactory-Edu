using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_003
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i = 2;
            while(true)
            {
                int j = 1;
                while (true)
                {
                    Console.Write( i + " * " + j + " = "  + (i * j) + "　");

                    if(++j > 9)
                    {
                        break;
                        
                    }
                }
                if(++i>9)
                {
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */
            /*
            int sum = 0;
            int n = 1;

            while(n ++ <= 1000)
            {
                if ((n % 2) != 0)
                {
                    //continue; // sum+=n;구문을 건너뛰고, while문의 조건식 평가로 실행을 옮긴다.
                    Console.WriteLine(sum);
                }
                sum += n;
            }
            */
            /*
                 int iCommand;
                 while (true)
                 {
                     Console.WriteLine("====================");
                     Console.WriteLine("======= 메뉴 =======");
                     Console.WriteLine("= 1. 안녕          =");
                     Console.WriteLine("= 2. 헬로          =");
                     Console.WriteLine("= 3. 종료          =");
                     Console.WriteLine("====================");
                     iCommand = int.Parse(Console.ReadLine());
                     if ((iCommand < 1) || (iCommand > 3))
                     {
                         continue;
                     }
                     if (iCommand == 1)
                     {
                         Console.WriteLine("안녕");
                     }
                     else if (iCommand == 2)
                     {
                         Console.WriteLine("헬로");
                     }
                     break;
                 */

            int iN;
            int iSum = 0;

            for(iN = 1; iN<1000; iN++)
            {
                if((iN%3==0)||(iN%5==0))
                {
                    iSum = iSum + iN;
                    Console.WriteLine(iSum);
                }
            }
            Console.WriteLine("★ {0} ★", iSum);

             

                }
            }
        }
    

