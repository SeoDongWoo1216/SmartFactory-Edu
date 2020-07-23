
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
            Console.WriteLine("=============================");
            int[,] iArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("GetLength(0) " + iArray.GetLength(0));
            Console.WriteLine("GetLength(1) " + iArray.GetLength(1));
            Console.WriteLine("GetUpperBound(0) " + iArray.GetUpperBound(0));
            Console.WriteLine("GetUpperBound(1) " + iArray.GetUpperBound(1));
            Console.WriteLine("Length " + iArray.Length);
            Console.WriteLine("=============================");


            Console.WriteLine("Reverse Test : 1, 2, 3, 4, 5, 6 뒤집기");
            int[] i1Array = { 1, 2, 3, 4, 5, 6 };
            Array.Reverse(i1Array);
            foreach (int iTemp in i1Array)
            {
                Console.Write(iTemp + " ");
            }
            Console.WriteLine("\n=============================");


            Console.WriteLine("Sort Test : 7, 200, 2, 65, 84, 11 정열");
            int[] i2Array = { 7, 200, 2, 65, 84, 11 };
            Array.Sort(i2Array);
            foreach (int iTemp in i2Array)
            {
                Console.Write(iTemp + " ");
            }
            Console.WriteLine("\n=============================");


            Console.WriteLine("BinarySearch Test : 11의 위치(인덱스 번호) 검색");
            int iResult = Array.BinarySearch(i2Array, 11);  // 정렬된 11의 위치를 검색
            Console.WriteLine("BinarySearch " + iResult);   // 11의 위치의 index(번호)를 반환해준다
            Console.WriteLine("============================="); 


            Console.WriteLine("Clear Test : 6, 5, 4, 3, 2, 1에서 [3]부터 2개 삭제");
            Array.Clear(i1Array, 3, 2);
            foreach (int iTemp in i1Array)
            {
                Console.Write(iTemp + " ");
            }
            Console.WriteLine("\n=============================");


            // 사용방법 : Array.를 찍으면 리스트가 뜨는데 사용설명이 나오는데 이걸보며 유추를해야함..
            // 사용방법이 띄워져있을때 F1를검색하면 인터넷에 설명이 나옴
            // 인자 인수 매개변수 같은말임
            // int32 : 32비트 int형, 특정요소 : Object
        }
    }
}