using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200527_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iMoney;    // iMoney 배열 선언
            iMoney = new int[20];   
            Console.WriteLine(iMoney.GetLength(0));    //GetLength : 길이 구하는애
            Console.WriteLine();
            /*
            int[,] i2Array = new int[2,3];
            i2Array[0, 0] = 1000;                 
            i2Array[0, 1] = 1004;
            i2Array[0, 2] = 1008;
            i2Array[1, 0] = 1012;
            i2Array[1, 1] = 1016;
            i2Array[1, 2] = 1020;
            */

            //위의 값들을 한꺼번에 넣어보자
            int[,] i2Array = { { 1000, 1004, 1008 },
                               { 1012, 1016, 1020 }};

            
            int iCount1;     // 표의 형태로 출력해보자
            int iCount2; 
            for(iCount1 = 0; iCount1 < 2; ++iCount1)
            {
                for (iCount2 = 0; iCount2 <= 2; ++iCount2)
                {
                    Console.Write("{0}\t", i2Array[iCount1, iCount2]);
                }
                Console.WriteLine();
            }
           
            /*    
            int iCount = 0;            // 강사님이 foreach문으로 표를 출력해줌
            foreach(int iNum in i2Array)
            {
                if (iCount % i2Array.GetLength(1) == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(iNum + " ");
                ++iCount;
            }
            Console.WriteLine();
        */


            /*
                        iMoney[0] = 1000;    // 제일 첫번째 사람은 천원
                        iMoney[1] = 1004;    // 두번째 사람은 1004원
                        iMoney[2] = 1008;    // 세번째 사람은 1008원
                                             // 20개를 넣는게 귀찮으니까 반복문을 사용해보자
            */
            /*
           int iCount;
            for (iCount=0;iCount<20;++iCount)
               {
                            iMoney[iCount]=(1000+(4*iCount));
                            Console.WriteLine(iMoney[iCount]);
                }
            Console.WriteLine();
    
            foreach (int iNum in iMoney)     // 결과는 동일한데 좀 더 간단함
            { 
                Console.WriteLine(iNum);
            }
            */












            /*
            Student st1;   // 3가지를 가지고있는 st1
            st1.Name = "홍길동";             // .은 왼쪽 안에있는 애 중에 사용할꺼라는뜻
            st1.Birth = 950615;
            st1.Num = 1234567;          
            Console.WriteLine("이름 : {0} " , st1.Name);     
            Console.WriteLine("생년 : {0}" , st1.Birth);   
            Console.WriteLine("학번 : " + st1.Num);
            Console.WriteLine("학번 : {0:X}", st1.Num);   // {0:X} 해당 숫자를 16진수로 표현
            */
        }
    }
}
