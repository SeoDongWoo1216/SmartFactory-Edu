using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_003
{
    class Program
    {
        private static void OutputArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수 : " + arr.Rank);  // Rank 프로퍼티
            Console.WriteLine("배열의 요소 수 : " + arr.Length); // Length 프로퍼티
            Console.WriteLine();
        }
        private static void OutputArrayElements(string title, Array arr)
        {
            Console.WriteLine("[" + title + "]");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr.GetValue(i) + ","); // GetValue 인스턴스 메서드
            } //(GetValue : 지정된 인덱스의 배열 요소 값을 반환한다)
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray); // Sort 정적 메서드(Sort : 값의 순서대로 정렬)
            OutputArrayElements("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);  // Copy 정적 메서드

            OutputArrayElements("intArray로 부터 복사된 copyArray", copyArray);
         }
    }
}





/*
           long A = 0x1234567801ABCDEF;  // 16진수이므로 두자리가 1바이트이다.
           // 1234 5678 (4바이트)   01AB CDEF (4바이트)
           int B = 0x01ABCDEF;
           
            Console.WriteLine("Hash A : {0:X}", A.GetHashCode());
            Console.WriteLine("Hash B : {0:X}", B.GetHashCode());
*/
/* 출력결과 (짤려서 나옴)
 Hash A : 139F9B97
Hash B: 1ABCDEF
*/
