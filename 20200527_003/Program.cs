using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200527_003
{
    class Program
    {
        static void Main(string[] args)
        {
           int[,] iArray = { { 1, 2, 3 }, { 4, 5, 6 } };

           Console.WriteLine("GetLength(0)의 값 : {0}\n",iArray.GetLength(0));  // iArray 행의 개수 = 2개
           Console.WriteLine("GetLength(1)의 값 : {0}\n",iArray.GetLength(1));  // iArray 열의 개수 = 3개
           Console.WriteLine("GetUpperBound(0)값 : {0}\n", iArray.GetUpperBound(0)); // iArray
           Console.WriteLine("Length : {0}\n", iArray.Length);    // iArray의 총 개수 = 6개

            Console.Write("Sort 값 : ");
            int[] i1Array = { 5, 4, 3, 2, 1, 6 };
            Array.Sort(i1Array);            // i1Array의 작은 순서부터 배열 
            foreach (int sortNumber in i1Array)
            { // 1 2 3 4 5 6
                Console.Write(" " + sortNumber);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Binary Search 값 : {0}", Array.BinarySearch(i1Array, 3));
            // 정렬된 i1Array의 3번째의 값이 뭐냐? 4
            // BinarySearch는 정렬된 상태에서만 가능함
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("리버스(거꾸로) 정렬 : ");
            int[] i2Array = { 1,2,3,4,5,6 };
            Array.Reverse(i2Array, 1, 4);
            foreach (int ReverseNumber in i2Array)
            {
                Console.Write(" " + ReverseNumber);
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(i2Array, 2, 3);
            Console.Write("i2Array에서 2번째꺼부터 3개를 기본값으로 변형(0으로만듬) : ");
            foreach (int ReverseNumber in i2Array)
            {
                Console.Write(" " + ReverseNumber);
            }
            Console.WriteLine();
        }
    }
}
