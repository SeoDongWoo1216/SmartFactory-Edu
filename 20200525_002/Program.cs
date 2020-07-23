using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_002
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int iNum;
            Console.WriteLine("정수를 입력하세요");
            iNum = int.Parse(Console.ReadLine());

            if(true)
            {                           
                Console.WriteLine("참입니다.");
            }
            if (false)
            {
                Console.WriteLine("거짓입니다.");
            }
            // false는 사용하지 않음
            /*

            /*
            int iNum;
            Console.WriteLine("정수를 입력하세요");
            iNum = int.Parse(Console.ReadLine());

            if(100 < iNum)
            {
                Console.WriteLine("입력한 정수는 100보다 큽니다");
            }
            */

            /*
             int iNum;
             Console.WriteLine("정수를 입력하세요");
             iNum = int.Parse(Console.ReadLine());

             if (iNum % 10 == 0) 
             {
                 if (iNum % 3 == 0)
                 {
                     Console.WriteLine("입력하신 정수는 10의 배수이면서 3의 배수입니다.");
                 }
                 // 이렇게 if문을 두번쓰면 중복됬다고 표현
            */
            /*
            int iNum;
            Console.WriteLine("정수를 입력하세요");
            iNum = int.Parse(Console.ReadLine());

            if((iNum % 10 == 0) && (iNum % 3 == 0))         // 두개 동시에 만족하는 &&(and) 논리연산자를 사용
            {       
                    Console.WriteLine("입력하신 정수는 10의 배수이면서 3의 배수입니다.");
                }
            */

            /*
            
            int iNum;
            Console.WriteLine("정수를 입력하세요");
            iNum = int.Parse(Console.ReadLine());

            if(iNum%2==0)
            {
                Console.WriteLine("입력하신 정수는 짝수입니다.");
            }
            else
            {
                Console.WriteLine("입력하신 정수는 홀수입니다.");
            }

            */

            int iNum;
            Console.WriteLine("점수를 입력하세요");
            iNum = int.Parse(Console.ReadLine());

            if (iNum > 90)
            {
                Console.WriteLine("A 입니다.");
            }
            else if (iNum > 80)       
            {                          
                Console.WriteLine("B 입니다.");
            }





        }
    }
}
