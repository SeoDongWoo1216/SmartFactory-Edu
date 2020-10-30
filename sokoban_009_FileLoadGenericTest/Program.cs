using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokoban_009_FileLoadGenericTest
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> A = new List<string>();
            A.Add("################");
            A.Add("GGGGGGGGGGGGGGGG");

            Console.WriteLine(A[0]);
            Console.WriteLine(A[1]);


            string[] Map = new string[]
            {
              "GGGGGGGGGGGGGGGG", // 0
              "G##############G", // 1
              "G#####     ####G", // 2
              "G##         ###G", // 3
              "G##  @B.   ####G", // 4
              "G##   B.  #####G", // 5
              "G##       #####G", // 6
              "G##### ########G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
            };

        }
    }
}

