using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_006
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int iNum;
            Console.WriteLine("1~3까지의 숫자를 입력해주세요 : ");
            iNum = int.Parse(Console.ReadLine());
            
            switch (iNum)
            {
                case 1:
                    Console.WriteLine("첫째");
                    break;
                case 2:
                    Console.WriteLine("둘째");
                    break;
                case 3:
                    Console.WriteLine("셋째");
                   break;
                default:
                    Console.WriteLine("그외의 숫자를 입력했습니다.");
                    break;
            }
            */

            int iScore;
            Console.WriteLine("점수를 입력해주세요 : ");
            iScore = int.Parse(Console.ReadLine());

            iScore = iScore / 10;
            switch (iScore)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
    }
}
