using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 100;
            Console.WriteLine(iNum); // 100
            ++iNum;
            Console.WriteLine(iNum); // 101
            iNum = iNum + 1;
            Console.WriteLine(iNum); // 102
            int iNum2;

            iNum2 = ++iNum;
            // iNum = iNum + 1;
            // iNum2 = iNum;

            Console.WriteLine("iNum, iNum2 = {0} , {1}", iNum, iNum2);
            int iNum3;

            iNum3 = iNum++;
            // iNum3 = iNum;
            // iNum = iNum + 1;


            Console.WriteLine("iNum, iNum3 = {0} , {1}", iNum, iNum3);
            iNum++;
            ++iNum;
        }
    }
}
