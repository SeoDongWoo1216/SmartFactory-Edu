using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_001
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int iCount;
            iCount = 5;

            while(iCount>0)
            {
                Console.WriteLine("TEST");
               // --iCount;
            }
            */

            int iCount;

            for (iCount = 5; iCount > 0; --iCount)
            {
                Console.WriteLine("TEST");
            }
            Console.WriteLine(iCount);


        }
    }
}
