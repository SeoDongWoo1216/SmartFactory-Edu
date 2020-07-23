using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_002
{
    struct Book  // 얘는 클래스보다는 떨어지지만 값이어서 New없이 쓸 수 있다.
    {
        public string Name;   // 기본적으로는 private가 적용되기때문에 public를 해주면 다른 메서드에도 쓸 수 있다
        public int Price;

        static Book()   // 스태틱이기때문에 한번만 호출되었다
        {
            Console.WriteLine("생성자 호출 됬냐?");
        }
        public void test()
        {
            Console.WriteLine("북 메서드 되냐?");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main 시작");
            Book aBook;
            aBook.Name = "test";
            aBook.Price = 100;
            aBook.test();

            Book aBook2;
            aBook2.Name = "test";
            aBook2.Price = 100;
            aBook2.test();
        }
    }
}
