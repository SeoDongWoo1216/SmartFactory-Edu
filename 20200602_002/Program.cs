using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_002
{
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
            short n1 = 256;
            short n2 = 32750;
            short n3 = 256;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(n3.GetHashCode());

            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.GetHashCode());
            Console.WriteLine(book2.GetHashCode());
        }
    }
}

/*
            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);
            Book book3 = book1;
            Console.WriteLine(book1.Equals(book2));  // 출력결과 : False
            Console.WriteLine(book1.Equals(book3));  // 출력결과 : True
            */

/*
string aString1 = "test";
string aString2 = "test";
string aString3 = aString1;
if (aString1.Equals(aString2))
{
    Console.WriteLine("문자열이 같습니다");
}
if (aString1.Equals(aString3))
{
    Console.WriteLine("문자열이 같습니다");
}
*/
/*
string aString1 = new String(new char[] { 't', 'e', 'x', 't' });
string aString2 = new String(new char[] { 't', 'e', 'x', 't' });
string aString3 = aString1;
Console.WriteLine(aString1.Equals(aString2));  // 출력결과 : True
if (aString1.Equals(aString2))
{
    Console.WriteLine("문자열이 같습니다");
}
if (aString1.Equals(aString3))
{
    Console.WriteLine("문자열이 같습니다");
}
*/

