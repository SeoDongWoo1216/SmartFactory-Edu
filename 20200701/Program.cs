using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Param6_1
{
    using System;
    public class ParamValue
    {
        public static void VarMethod(params object[] arr)
        {
            Console.WriteLine("[가변 인자 개수] : " + arr.Length + "개");
            
            Console.Write("[인자 전체]  :  ");
            foreach(object one in arr) // object는 최상위라서 아무타입이나 다 받는다.
            {
                Console.Write(one.ToString() + "  ");
            }
            Console.WriteLine();

            Console.Write("[문자열 타입] :  ");
            for(int i = 0; i<arr.Length; ++i)
            {
                Type t = arr[i].GetType();
                if (t.Equals(typeof(System.String)))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();

            Console.Write("[정수 타입] : ");
            foreach(object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Int32)))
                {
                    Console.Write(one + "  "); // .Tostring()이 생략되어있다.
                }
            }
            Console.WriteLine();

            Console.Write("[Float 타입] : ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Single)))
                {
                    Console.Write(one + "  ");
                }
            }
            Console.WriteLine();

            Console.Write("[실수 타입] : ");
            foreach (object one in arr)
            {
                Type t = one.GetType();
                if (t.Equals(typeof(System.Double)))
                {
                    Console.Write(one + "  ");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            VarMethod(1000, 2000, "3000", "헬로", 3.1, 3.2f);
            // 3.1은 더블형, 3.2f는 float형 
        }
    }
}









//namespace param6
//{
//    using System;

//    public class VariableLength
//    {
//        public int VerMethod(params int[] arr)
//        {
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                sum = sum + arr[i];
//            }

//            return sum;
//        }
//        public static void Main(string[] args)
//        {
//            int result;
//            VariableLength vl = new VariableLength();
//            result = vl.VerMethod(10, 20);
//            Console.WriteLine(result);
//            result = vl.VerMethod(1, 2, 3, 4);
//            Console.WriteLine(result);
//            //가변인자
//        }
//    }

//}


//using System;

//    public class ParamValue
//{
//    public void Increase(out int n)
//    {
//        n = 11;
//    }

//    static void Main(string[] args)
//    {
//        int i = 6;
//        ParamValue pv = new ParamValue();
//        pv.Increase(out i);
//        Console.WriteLine("호출 후 값 : {0}", i);
//        Console.WriteLine("i의 값 : {0}", i);
//        // 출력인자 방식
//    }
//}