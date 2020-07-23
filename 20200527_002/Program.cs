using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200527_002
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { {1,2,3 }, {4,5,6} };
            for(int i=0; i<arr.GetLength(0); i++)   // arr.getLength(0)은 arr행의 개수 2
            {
                for(int j=0; j< arr.GetLength(1); j++)  // arr.getLength(1) arr열의 개수 3
                {
                    Console.Write("[{0}, {1}] : {2}\t", i, j, arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write("[{0}, {1}] : {2}\t", i, j, arr2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int[,] arr3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("[{0}, {1}] : {2}\t", i, j, arr3[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            foreach(int a in arr3)
            {
                Console.WriteLine("{0}", a);
            }
        }
    }
}
