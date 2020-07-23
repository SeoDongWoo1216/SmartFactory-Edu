using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _20200602_001
{
    class A
    {
    }
    class B : A
    {
    }
    class C : B
    {
    }

    class Book
    {
        decimal _isbn;

        public Book(decimal isbn)
        {
            _isbn = isbn;
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.Equals(book2));  // 출력 =결과 : False
        }
    }
}

/*
            A aObj = new A();
            B bObj = new B();
            C cObj = new C();

            A aRef;
            B bRef;
            C cRef;

            Console.WriteLine(aObj.ToString());
            Console.WriteLine(bObj.ToString());
            Console.WriteLine(cObj.ToString());
            Console.WriteLine();
            
            //5출력
            Console.WriteLine(5);
            Console.WriteLine('5');
            Console.WriteLine(5 + '0');
            Console.WriteLine((char)(5 + '0'));
            Console.WriteLine();
            
            //500출력
            Console.WriteLine(500);
            Console.WriteLine("{0}{1}{2}", '5', '0', '0');
            Console.WriteLine("{0}{1}{2}", (char)(5 + '0'), (char)(0 + '0'), (char)(0 + '0'));
            Console.WriteLine();

            */
/*
            // 퀴즈1 : aRef가 가리킬 수 있는 객체는 모두 몇 개 인가?
            aRef = aObj;
            aRef = bObj;
            aRef = cObj;
            // 퀴즈2 : bRef가 가리킬 수 있는 객체는 모두 몇 개 인가?
            bRef = bObj;
            bRef = cObj;
            // 퀴즈3 : cRef가 가리킬 수 있는 객체는 모두 몇 개 인가?
            cRef = cObj;
            //cRef = aObj;
            object oRef;
            oRef = aObj;
            oRef = bObj;
            oRef = cObj;
            */

/*
            //149p 첫번째 예제
            int n = 500;
            double d = 3.14123123141245;

            string txt = "Hello: ";

            Console.WriteLine(txt + n.ToString());
            Console.WriteLine(txt + d.ToString());

            txt = d.ToString();
            */

/*
             // 149p 두번째 예제
            C c = new C();
            Type type = c.GetType();

            Console.WriteLine(type.FullName);  // 풀네임 호출
            Console.WriteLine(type.IsClass);   // 니가 클래스니?
            Console.WriteLine(type.IsArray);   // 니가 배열이니?
            Console.WriteLine();
            */


/*
             // 150p 두번째 예제
            Type type = typeof(double);
            Console.WriteLine(type.FullName);
            Console.WriteLine(typeof(System.Int16).FullName);
            Console.WriteLine();
            */

/*
            //150p 첫번째예제
            int n = 5;
            string txt = "text";

            Type intType = n.GetType();

            Console.WriteLine(intType.FullName);
            Console.WriteLine(txt.GetType().FullName);
            Console.WriteLine();
            */


/*
            // 151p 첫번째 예제
          int n = 5;
          Console.WriteLine(n.Equals(5));   // 출력결과 : True


            // 값형식과 참조형식에 대해 달라진다. 값형식은 해당 인스턴스가 소유하고있는 값을 대상으로 비교
            // 참조형식에서는 할당된 메모리 위치를 가리키는 식별자의 값이 같은지 비교
            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));  // 출력결과 : True

            n2 = 6;
            Console.WriteLine(n1.Equals(n2));  // 출력결과 : False
            */
