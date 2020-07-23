using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Param1
//{
//    using System;
//    public class ParamValue
//    {
//        public void Increase(int n)
//        {
//            n++;
//        }

//        public static void Main(string[] args)
//        {
//            int i = 10;
//            ParamValue pv = new ParamValue();
//            Console.WriteLine("호출 전 : {0}", i);
//            pv.Increase(i);
//            Console.WriteLine("호출 후 : {0}", i);
//            // 메서드 간의 지역변수는 분리된다.
//            // 호출 전 후와 값은 같다.
//        }
//    }
//}

//namespace Param2
//{
//    using System;

//    public class ParamRef
//    {
//        public int myVal = 10;
//    }
//    public class ParamTest
//    {
//        public static void Increase(ParamRef varRef)
//        {
//            varRef.myVal++;
//        }
//        public static void Main(string[] args)
//        {
//            ParamRef pr = new ParamRef(); // 
//            Console.WriteLine("호출 전 : {0}", pr.myVal);
//            ParamTest.Increase(pr);
//            Console.WriteLine("호출 후 : {0}", pr.myVal);
//        }
//    }
//}


//namespace Param3
//{
//    using System;

//    public class ParamValue
//    {
//        public void Increase(ref int n)
//        {
//            n++;
//        }

//        public static void Main(string[] args)
//        {
//            int i = 10;
//            ParamValue pv = new ParamValue();
//            Console.WriteLine("호출 전 : {0}", i);
//            pv.Increase(ref i);
//            Console.WriteLine("호출 후 : {0}", i);
//        }
//    }
//}


//namespace Param4
//{
//    using System;

//    public class ParamRef
//    {
//        public int myVal = 10;
//    }
//    public class ParamTest
//    {
//        public static void Increase(ref ParamRef varRef)
//        {
//            varRef.myVal++;
//        }
//        public static void Main(string[] args)
//        {
//            ParamRef pr = new ParamRef(); // 
//            Console.WriteLine("호출 전 : {0}", pr.myVal);
//            ParamTest.Increase(ref pr);
//            Console.WriteLine("호출 후 : {0}", pr.myVal);
//        }
//    }
//}





//public static int classvari1;
//public int classvari2;

//public Example()
//{
//    classvari1++;
//    classvari2++;
//}
//public void Print()
//{
//    Console.WriteLine("classvari1 : " + classvari1);
//    Console.WriteLine("classvari2 : " + classvari2);
//    Console.WriteLine();
//}

////메인폼에했던거
//Example e1;
//Example e2;
//e1 = new Example();
//e1.Print();

//            e2 = new Example();
//e2.Print();

//            e1.Print();








//public static ulong Factorial(ulong number)
//{
//    if (number <= 1) return 1;
//    else
//        return number * Factorial(number - 1);
//}






//public static void MethodA()
//{
//    System.Console.WriteLine("메서드 A입니다.");
//}
//public static void MethodB()
//{
//    MethodA();
//    System.Console.WriteLine("메서드 B입니다.");
//    MethodA();
//}

//public class A
//{
//    public static void MethodA()
//    {
//        System.Console.WriteLine("MethodA() in class A");
//    }
//}



//int a, b;
//float c = 0;

//while (true)
//{
//    try
//    {
//        Console.Write("첫번째 정수를 입력하세요 : ");
//        a = int.Parse(Console.ReadLine());
//        Console.Write("두번째 정수를 입력하세요 : ");
//        b = int.Parse(Console.ReadLine());
//        c = a / b;
//    }
//    catch (FormatException eObj)
//    {
//        Console.WriteLine(eObj);
//        Console.WriteLine("숫자가 아닌 문자를 입력했습니다");
//        continue;
//    }
//    catch (DivideByZeroException eObj)
//    {
//        Console.WriteLine(eObj);
//        Console.WriteLine("0으로 나누려했습니다.");
//        continue;
//    }
//    catch (Exception eObj)
//    {
//        Console.WriteLine(eObj);
//        Console.WriteLine("변수의 값이 올바르지 않습니다.");
//        continue;
//    }
//    finally
//    {
//        Console.WriteLine("\n프로그램이 실행 되었습니다.");
//        Console.Clear();
//    }
//    Console.WriteLine("A/B값은 {0} 입니다.", c);
//    break;
//}