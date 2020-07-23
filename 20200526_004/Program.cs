using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200526_004
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();  // test call : test 메소드를 호출했다.
            test4(20, 40);
            test5();            // return에서 0을 가지고 돌아옴
            int iNum = test5(); // 마찬가지로 21을 가지고 돌아오기때문에 
                                // iNum에 21이 대입된다.
                                // 이때 return으로 가지온 값을 리턴값이라 부른다.
            Console.WriteLine("Main : {0}", iNum);
            iNum = test6(100, 200);
            Console.WriteLine("Main : {0}", iNum);
        }
        static void test1()
        {
            Console.WriteLine("test1");
            return; 
        }
        static void test4(int iTest41, int iTest42)
        {
            Console.WriteLine("test3 : [" + iTest41 + "," + iTest42 + "]");
        }
        static int test5()
        {
            Console.WriteLine("test5");

            return 21;     // int와 21 자리의 변수타입이 일치해야함
                           // void에도 return;을 써줘야하는데 생략되어있는것임
                           // int 21 을가지고 메인으로 간다

            
        }
        static int test6(int itest61, int itest62)
        {
            Console.WriteLine("test6");

            return itest61 + itest62;  // return value 

        }
    }
}
