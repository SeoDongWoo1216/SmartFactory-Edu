using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200522_003
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Console.WriteLine("아무 글이나 써보세요");
             string input = Console.ReadLine();
            Console.WriteLine("입력하신 내용은 [{0}] 입니다", input);
            */
            /*  
              Console.WriteLine("입력받았습니다.");
               Console.Write("입력하신 내용은 [");
               Console.Write(input);
               Console.WriteLine("] 입니다.");
           */


            /*
            int iNum = 100;
            Console.Write("내장된 자료의 값은[");
            Console.Write(iNum);
            Console.WriteLine("]입니다");
        */

            /*
            int iNum2 = 100;
            int iNum3 = 200;
            Console.WriteLine("내장된 자료의 값은 [{0}][{1}] 입니다.", iNum2, iNum3);
          */

            /*
            int iNumber;
            Console.Write("정수를 입력하세요 :  ");
            iNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("입력하신 숫자는 [{0}] 입니다", iNumber);
            */
           
            int iNumber1;
            int iNumber2;
            Console.Write("첫번째 정수를 입력하세요 :  ");
            iNumber1 = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력하세요 :  ");
            iNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 수의 합은 [{0}] 입니다.", iNumber1+iNumber2);
            Console.WriteLine("두 수의 차는 [{0}] 입니다.", iNumber1 - iNumber2);
            Console.WriteLine("두 수의 곱은 [{0}] 입니다.", iNumber1*iNumber2);
 
            
        }
    }
}
