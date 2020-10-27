using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sokoban_007_002
{
    class Program
    {
        // 문자열을 배열로 바꿔서 수정할 수 있도록 ToCharArray를 시켜준다.
        // 이렇게함으로써 데이터 수정이 가능하고 원래 데이터는 건드리지 않음.

        static string[] Map = new string[10]  // static을 통해 Map을 일단 그리게함
           {
              "GGGGGGGGGGGGGGGG", // 0
              "G##############G", // 1
              "G##### ########G", // 2
              "G##### ########G", // 3
              "G##   @B  .####G", // 4
              "G##### ########G", // 5
              "G##### ########G", // 6
              "G##### ########G", // 7
              "G##############G", // 8
              "GGGGGGGGGGGGGGGG"  // 9
           };


        static void Main(string[] args)
        {
            char[][] TT = new char[10][];

            for(int i = 0; i < Map.Length; ++i)
            {
                TT[i] = Map[i].ToCharArray();
                //Console.WriteLine(Map[i]);
            }

            //foreach (var AAA in TT)
            //{
            //    foreach (var Temp in AAA)
            //    {
            //        Console.Write(Temp);
            //    }
            //    Console.WriteLine();
            //}

            //foreach (var Temp in TT)
            //{
            //    Console.WriteLine(Temp);
            //}

            /*
            TT[0] = Map[0].ToCharArray();
            TT[1] = Map[1].ToCharArray();
            TT[2] = Map[2].ToCharArray();
            TT[3] = Map[3].ToCharArray();
            TT[4] = Map[4].ToCharArray();
            TT[5] = Map[5].ToCharArray();
            TT[6] = Map[6].ToCharArray();
            TT[7] = Map[7].ToCharArray();
            TT[8] = Map[8].ToCharArray();
            TT[9] = Map[9].ToCharArray();
            */



        }

        static void Main2(string[] args) 
        {
        char[] TT0 = Map[0].ToCharArray();
        char[] TT1 = Map[1].ToCharArray();

        foreach (var Temp in TT1)
        {
            Console.Write(Temp);
        }

        }
        static void Main1(string[] args)
        {
            char[] TT1 = Map[0].ToCharArray();   // GGGGGGGGG를 배열로 G,G,G,G ... 로 바꿈
            TT1[1] = '#';

            foreach (var Temp in TT1)  // 수정이 잘 됬는지 확인
            { 
                Console.Write(Temp);
            }
            Console.WriteLine();

            foreach (var Temp in Map[0])  // Map[0] 데이터는 그대로있는지 확인
            {
                Console.Write(Temp);
            }
        }
    }
}
