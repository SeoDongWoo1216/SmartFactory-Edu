using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokoban_010_001generic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Temp1 = new string[]
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

            string[] Temp2 = new string[]
            {
              "################", // 0
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

            string[,] Temp3 = new string[,]
            {
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
                },
                {  
              "################", // 0
              "G##############G", // 1
              "G#####     ####G", // 2
              "G##         ###G", // 3
              "G##  @B.   ####G", // 4
              "G##   B.  #####G", // 5
              "G##       #####G", // 6
              "G##### ########G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
                }
            };

            //List<string> aList = new List<string>();
            //foreach (var TTT in Temp)
            //{
            //    aList.Add(TTT);
            //}

            //foreach (var TTT in Temp)
            //{
            //    Console.WriteLine(TTT);
            //}


            List<string[]> aList = new List<string[]>();
            aList.Add(Temp1);
            aList.Add(Temp2);

            //foreach (var TTTT in Temp1)
            //{
            //    Console.WriteLine(TTTT);
            //}
            //Console.WriteLine();

            //foreach (var TTTT in Temp2)
            //{
            //    Console.WriteLine(TTTT);
            //}
            //Console.WriteLine();


            string[][] Map = aList.ToArray();

            foreach (var TTTT in Map[0])
            {
                //Console.WriteLine(TTTT);
            }
            Console.WriteLine();
            foreach (var TTTT in Map[1])
            {
                //Console.WriteLine(TTTT);
            }

            List<int> aList2 = new List<int>();
            foreach(var TTT in aList2)
                Console.WriteLine(TTT);
        }
    }
}
