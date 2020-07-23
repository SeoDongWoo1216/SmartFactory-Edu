using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_002
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int iCount1;
            int iDan;

          for(iCount1 = 2; iCount1 < 10; ++iCount1)
            {
                for(iDan = 1; iDan <10; ++iDan)
                {
                    Console.Write("{0} * {1} = {2}  ", iCount1, iDan, iCount1 * iDan);
                }
                Console.WriteLine('\n');
            }    
            

            /*
            int iCount;
            int iDan;
            Console.WriteLine("출력할 구구단을 입력하세요");
            iDan = int.Parse(Console.ReadLine());
            for(iCount = 1; iCount < 10; ++iCount)
            {
                Console.WriteLine("{0} * {1} = {2}", iDan, iCount, iCount * iDan);
            }
            */
    
        }
    }
}
