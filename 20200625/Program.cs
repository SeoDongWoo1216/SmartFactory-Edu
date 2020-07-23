// 프롤로그 시작
using System;    // 시스템 함수, 이것을 쓰겠다.(System.Console.write -> Console.Write로 쓰게해줌)
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _20200625_001   // 네임스페이스 : 회사로따지면 부서 같은 곳, 개발하는 공간을 서로 독립적으로 쓰기위해서
// 프롤로그 끝
{
    enum Week
    {
        Mon = 100,
        Tue,
        Wed,
        Thu = 200,
        Fri,
        Sat,
        Sun
    }
    class Program   //  클래스
    {
        static void Main(string[] args)      //  Main 메서드 & 엔트리 포인트
            //  Main  메서드의 인자/인수/매개변수 : 1개, 이름은 args
        {
            //string inValue = Console.ReadLine();
            //Console.WriteLine("{0}\n\n", inValue);  // inValue 변수로 문자열을 입력 받아서 출력하는 소스

            //Console.WriteLine("{0:C}\n", 100); // Currency 타입 : 통화표시를 함께 사용
            //Console.WriteLine("{0:D}\n", 00001024); // Decimal 타입 : 10진수로 출력
            //Console.WriteLine("{0:E}\n", 100); //Scientific : 과학적 지수, 지수형태로 출력
            //Console.WriteLine("{0:F}\n", 100);  // Fixed Point(고정 소숫점) : 소수점 자리수를 정해서 표현
            //Console.WriteLine("{0:G}\n", 10000); // General :  정수형이나 소수를 일반적으로 포현
            //Console.WriteLine("{0:N}\n", 100000); // Number타입 : ' , '가 나타나게 표현
            //Console.WriteLine("{0:X}\n", 100);  // Hexadecimal : 16 진수로 표현



            //int iNumber = 0x12345678;
            //Console.WriteLine(iNumber);


            //float fNumber = 41.625f;
            //Console.WriteLine("{0}\n", fNumber);


            Week GoodDay;
            Week Today;

            GoodDay = Week.Fri;   // Week안에있는 Fri (.으로 찾아준다)
            Today = Week.Thu;

            Console.WriteLine("GoodDay = {0}", GoodDay);
            Console.WriteLine("Today = {0}", Today);

            Console.WriteLine("GoodDay Index = {0}", (int)GoodDay);   // int형으로 변환하니까 숫자가 출력된다?
            Console.WriteLine("Today   Index = {0}", (int)Today);
            Console.WriteLine("Index = {0}", (int)Week.Mon);  // 100으로 시작해도 1씩 증가한다
            Console.WriteLine("Index = {0}", (int)Week.Tue);
            Console.WriteLine("Index = {0}", (int)Week.Wed);
            Console.WriteLine("Index = {0}", (int)Week.Thu);  // 중간에 200을 넣어도 200부터 1씩증가
            Console.WriteLine("Index = {0}", (int)Week.Fri);
            Console.WriteLine("Index = {0}", (int)Week.Sat);
            Console.WriteLine("Index = {0}", (int)Week.Sun);
        } 
    }
}