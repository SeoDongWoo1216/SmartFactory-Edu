using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_004
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("년도를 입력하세요 : ");
            int iYear;
            iYear = int.Parse(Console.ReadLine());
           
            
            if (iYear % 4 ==0 && iYear % 100 == 0 && iYear % 400 == 0)
            {
                Console.WriteLine("{0}년은 윤년입니다.", iYear);
            }
            else if (iYear % 4 == 0 && iYear % 100 == 0)
            {
                Console.WriteLine("{0}년은 평년입니다.", iYear);
            }
            else if (iYear % 4 == 0)
            {
                Console.WriteLine("{0}년은 윤년입니다.", iYear);
            }
            else
            {
                Console.WriteLine("{0}년은 평년입니다.", iYear);
            }

            
            // 서력 기원 연수가 4로 나누어 떨어지는 해는 윤년으로 한다. ...
            // 서력 기원 연수가 4, 100으로 나누어 떨어지는 해는 평년으로 한다. ...
            // 서력 기원 연수가 4, 100, 400으로 나누어 떨어지는 해는 윤년으로 둔다.
            */

            /*
            Console.Write("년도를 입력하세요 : ");
            int iYear;
            iYear = int.Parse(Console.ReadLine());

            if(iYear%400 == 0)       // 400으로 나눠떨어질때 윤년
            {
                Console.WriteLine("{0}년은 윤년입니다.", iYear);
            } 
            else       // 400으로 안나누어 떨어질때 : 평년, 윤년이 섞여있음
            {
                 // 4로 떨어지는 해는 윤년 후보(평년, 윤년 섞여있음)
                if (iYear % 4 == 0)
                {
                    if (iYear % 100 != 0)     // 100으로 나누어 떨어지지않음
                    {
                        Console.WriteLine("{0}은 윤년입니다.", iYear);
                    }
                    else        // 100으로 나누어 떨어지는 해는 평년
                    {
                        Console.WriteLine("{0}은 평년입니다.", iYear);
                    }
                }
                else          // 4로 나누어 떨어지지 않는 해 : 평년
                {
                    Console.WriteLine("{0}은 평년입니다.", iYear);
                }
            }
            */
        }
    }
}
