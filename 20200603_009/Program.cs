using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_009
{
    class Complex
    {
        int Real;
        int Image; // 참고로 클래스 변수는 초기화안하면 0이 들어가있다.
        public Complex(int Real, int Image)
        {
            this.Real = Real;
            this.Image = Image;
        }
        public override string ToString()
        {
            return "{ " + Real + " + " + Image + "i } ";
        }
        public static Complex operator +(Complex A, Complex B)
        {
            Complex C = new Complex(0, 0);   // 더하기 연산값을 저장할 공간 생성
            C.Real = A.Real + B.Real;
            C.Image = A.Image + B.Image;

            return C;
            // return new Complex((A.Real + B.Real), (A.Image + B.Image));
            // 위처럼 한줄로 줄여서 쓸 수도있다(이건 책에있는 방식)
        }
        public static Complex operator -(Complex A, Complex B)
        {
            Complex C = new Complex(0, 0);
            C.Real = A.Real - B.Real;
            C.Image = A.Image - B.Image;

            return C;
        }
        public static Complex operator *(Complex A, Complex B)
        {
            Complex C = new Complex(0, 0);
            C.Real = (A.Real * B.Real) - (A.Image * B.Image);
            C.Image = (A.Real * B.Image) + (A.Image * B.Real);

            return C;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex Num1 = new Complex(3, 4);
            Complex Num2 = new Complex(5, 6);
            Complex Num3 = Num1 + Num2;  // 컴파일러는 Complex라는 클래스를 처음봐서 덧셈을 할줄모르니 오류가 뜬다
                                         // Num1 + Num2가 C로 변함 -> Num3에 C를 대입
            Complex Num4 = Num1 - Num2;
            Complex Num5 = Num1 * Num2;
            Console.WriteLine(Num1);
            Console.WriteLine(Num2);
            Console.WriteLine(Num3);
            Console.WriteLine(Num4);
            Console.WriteLine(Num5);
        }
    }
}
// 각 메서드마다 스택에 C를 저장했는데 프로그램 종료될때 스택은 삭제되므로 문제가없다.