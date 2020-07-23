using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_003
{
    class Program
    {
        static void Main(string[] args)
        {
            int iScore;
            Console.Write("점수를 입력하세요 : ");
            iScore = int.Parse(Console.ReadLine());

            Console.Write("당신의 점수는 ");
            if (90 <= iScore)
            {
                Console.Write("A");
            }
            else if (80 <= iScore)
            {
                Console.Write("B");
            }
            else if (70 <= iScore)
            {
                Console.Write("C");
            }
            else if (60 <= iScore)
            {
                Console.Write("D");
            }
            else
            {
                Console.Write("F");
            }
            Console.WriteLine(" 입니다.");
            
    
        }
    }
}
