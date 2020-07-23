using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200522_001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("44p예제2");
            char ch1 = '\t';      // \(역슬래시)로 한칸을 띄울수있다.
            char ch2 = 'T';       // 이스케이프 시퀀스
            char ch3 = '\n';      // \(역슬래시)로 시작하는 특수문자표현
            char ch4 = 'o';       // 일반적인 문자로 표현할 수 없는 영역의 문자를 나타낼때 사용
            // \t \n등이 있음
            Console.Write(ch1);    // console.writeline();  에서 line이 \n을 덧붙여서 출력해주는 역할을한다.
            Console.Write(ch2);    // console.write();
            Console.Write(ch3);
            Console.Write(ch4);
            Console.WriteLine('\n');


            Console.WriteLine("45p예제1");
            char ch = '\uc548';     //\u 로 해당 숫자의 번호를 유니코드번호를 16진수로 명시할 수 있음
            Console.Write(ch);      //
            Console.WriteLine('\n');

            Console.WriteLine("45p예제2");
            char ch22 = '\\';
            Console.Write(ch22);    // \(역슬래시)를 출력하려면 두번으로 표현해주면된다.
            Console.WriteLine('\n');


            Console.WriteLine("46p예제1");
            string text = "Hello World";    //문자가 둘 이상인 경우 별도로 문자열이라고하며
            Console.WriteLine(text);        // string 타입으로 사용
            Console.WriteLine('\n');        // 문자열 값을 표현할때는 ""을 사용


            Console.WriteLine("46p예제2");
            string text1 = "\tHello\nWorld"; // 이스케이프 시퀀스도 사용가능
            Console.WriteLine(text1);
            Console.WriteLine('\n');


            Console.WriteLine("46p예제3");
            string text2 = "\"Hello World\"";  //""로 데이터를 포함시킬때도 이스케이프시퀀스사용
            Console.WriteLine(text2);
            Console.WriteLine('\n');


            Console.WriteLine("47p예제1");
            string text3 = @"\tHello\nWorld"; // '@'를 문자열앞에 붙이면 \를 순수 문자로 취급
            Console.WriteLine(text3);
            Console.WriteLine('\n');


            Console.WriteLine("47p예제2");
            string text4 = "Hello";           // char형과 달리 string은 '+'연산을 지원함
            Console.WriteLine(text4 + "" + "World");  // '+'로 문자열을 연결할 수 있다.
            Console.WriteLine('\n');

            

        }
    }
}
