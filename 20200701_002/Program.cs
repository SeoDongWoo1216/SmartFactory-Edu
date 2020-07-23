using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _20200701_002
//{
//    class Program
//    {
//        // 메서드 이름이 같더라도 매개변수, 즉 인자값으로 구별할 수 있다. -> 이것을 메서드 오버로딩이라고 부른다.
//        // 객체지향 용어이다.
//        static double Add(Double iNum1, Double iNum2)   
//        {
//            Double iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }
//        static float Add(float iNum1, float iNum2)
//        {
//            float iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }
//        static int Add(int iNum1, int iNum2)
//        {
//            int iNum3 = iNum1 + iNum2;

//            return iNum3;
//        }


//        //static double AddDouble(Double iNum1, Double iNum2)
//        //{
//        //    Double iNum3 = iNum1 + iNum2;

//        //    return iNum3;
//        //}
//        //static float AddFloat(float iNum1, float iNum2)
//        //{
//        //    float iNum3 = iNum1 + iNum2;

//        //    return iNum3;
//        //}
//        //static int AddInt(int iNum1, int iNum2)
//        //{
//        //    int iNum3 = iNum1 + iNum2;

//        //    return iNum3;
//        //}


//        static void Main(string[] args)
//        {
//            int Num1 = 3;
//            int Num2 = 4;
//            int Num3 = Num1 + Num2;

//            Console.WriteLine("{0} = {1} + {2}", Num3, Num1, Num2);

//            int iNum4 = Add(5, 6);
//            Console.WriteLine("{0} = {1} + {2}", iNum4, 5, 6);

//            float fNum5 = Add(5.1f, 6.1f);
//            Console.WriteLine("{0} = {1} + {2}", fNum5, 5.1f, 6.1f);

//            double dNum6 = Add(5.1, 6.1);
//            Console.WriteLine("{0} = {1} + {2}", dNum6, 5.1, 6.1);

//            //int iNum7 = Add(5, 6); // 이 코드는 사용자가 선택하지않았지만, 컴파일러가 자동으로 인자를 선택해서 출력해준다.

//            //오버로딩의 조건은 인자의 타입이지 반환타입은 전혀 상관이없다.
//            // 메서드의 이름이 같고 인자가 다르게 만드는 것을 메서드 오버로딩이라고한다.


//            //int iNum4 = AddInt(5, 6);
//            //Console.WriteLine("{0} = {1} + {2}", iNum4, 5, 6);

//            //float fNum5 = AddFloat(5.1f, 6.1f);
//            //Console.WriteLine("{0} = {1} + {2}", fNum5, 5.1f, 6.1f);

//            //double dNum6 = AddDouble(5.1, 6.1);
//            //Console.WriteLine("{0} = {1} + {2}", dNum6, 5.1, 6.1);

//            //
//        }
//    }
//}


namespace _20200701_002_001
{
    //class ArrayClass
    //{
    //    static void Main(string[] args)
    //    {
    //        System.Console.Write("행의 개수를 입력하세요. : ");
    //        string s1 = System.Console.ReadLine();

    //        System.Console.Write("열의 개수를 입력하세요. : ");
    //        string s2 = System.Console.ReadLine();

    //        int rows = int.Parse(s1);
    //        int cols = int.Parse(s2);

    //        int[,] myArray = new int[rows, cols];
    //        System.Console.WriteLine(rows + "*" + cols + "배열이 생성되었습니다.");
    //    }
    //}

    //using System;
    //class CopyArray
    //{
    //    static void Main(string[] args)
    //    {
    //        long[] Original = new long[4] { 3, 1, 2, 0 };
    //        long[] Copy = Original;
    //        Console.WriteLine("1 : " + Copy[3]);
    //        Original[3] = Original[1] + Original[2];

    //        long CopyValue = Copy[3];
    //        Console.WriteLine("2 : " + Copy[3]);
    //    }
    //}

    //using System;

    //class ArrayRank
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] Array1 = new int[4];
    //        int[,] Array2 = new int[2, 3];
    //        int[,,] Array3 = new int[2, 4, 3];

    //        Console.WriteLine("Array1의 차원 : " + Array1.Rank);
    //        Console.WriteLine("Array2의 차원 : " + Array2.Rank);
    //        Console.WriteLine("Array3의 차원 : " + Array3.Rank);
    //    }
    //}

    //using System;

    //class ArraySort
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 0;

    //        //배열선언
    //        int[] SortArray = new int[5] { 15, 32, 11, 20, 43 };

    //        Console.Write("현재배열 출력 : ");
    //        //for (i = 0; i < SortArray.Length; i++)
    //        //{
    //        //    Console.Write(SortArray[i] + " ");
    //        //}
    //        //foreach (int iNum in SortArray)
    //        //{
    //        //    Console.Write(SortArray[iNum]);
    //        //}
    //        Console.WriteLine();
    //        //sort메서드로 배열정렬
    //        System.Array.Sort(SortArray);
    //        // 정렬하는 메서드가 C#에 있는데 걔가 배열을 정렬시켜준다.

    //        Console.Write("정렬된 배열 출력 : ");
    //        for (i = 0; i < SortArray.Length; i++)
    //        {
    //            Console.Write(SortArray[i] + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //}


    //using System;

    //class ArrayClear1
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] ClearArray = { 5, 4, 2, 6, 7, 1 };

    //        Console.WriteLine("***********클리어 전*************");
    //        foreach(int iNum in ClearArray)
    //        {
    //            Console.WriteLine(iNum);
    //        }

    //        System.Array.Clear(ClearArray, 0, ClearArray.Length);
    //        Console.WriteLine("*************클리어 후****************");
    //        foreach(int iNum in ClearArray)
    //        {
    //            Console.WriteLine(iNum);
    //        }
    //    }
    //}

    //using System;

    //class ArrayClaer2
    //{
    //    static void Main(string[] args)
    //    {
    //        int i = 0;
    //        int[] ClearArray = { 5, 4, 2, 6, 7, 1 };
    //        System.Array.Clear(ClearArray, 1, 2);
    //        // [1]부터 두개를 지운다.
    //        for(i=0; i<ClearArray.Length; i++)
    //        {
    //            Console.WriteLine(ClearArray[i]);
    //        }
    //    }
    //}

    //using System;

    //class ArrayClone
    //{
    //    static void Main(string[] args) 
    //    { 
    //    int i = 0;
    //    int[] Original = { 5, 4, 2, 6, 7, 1 };
    //    int[] Clone = (int[])Original.Clone();
            
    //        for (i = 0; i<Clone.Length; i++)
    //        {
    //            Console.Write(Clone[i] + " ");
    //        }
    //        Console.WriteLine();
    //        Original[3] = 20;
    //        Console.WriteLine("복제계열[3] : " + Clone[3]);

    //    }
    //}

    
}