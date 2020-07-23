using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("당신의 점수를 입력하세요 : ");
            //int point = int.Parse(Console.ReadLine());;
            //string result;
            //if (point > 90)
            //{
            //    result = "A";
            //}
            //else if (point > 80)
            //{
            //    result = "B";
            //}
            //else if (point > 70)
            //{
            //    result = "C";
            //}
            //else if (point > 60)
            //{
            //    result = "D";
            //}
            //else
            //{
            //    result = "F";
            //}
            //Console.WriteLine("\n당신의 점수는 {0}입니다.", point);
            //Console.WriteLine("그리고 학점은 {0}입니다.", result);

            //int igrade= 82;

            //switch (igrade / 10)
            //{
            //    case 9:
            //        Console.WriteLine("당신의 점수는 A입니다.");
            //        break;
            //    case 8:
            //        Console.WriteLine("당신의 점수는 B입니다.");
            //        break;
            //    case 7:
            //        Console.WriteLine("당신의 점수는 C입니다.");
            //        break;
            //    case 6:
            //        Console.WriteLine("당신의 점수는 D입니다.");
            //        break;
            //    case 5:
            //        Console.WriteLine("당신의 점수는 F입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("정수 값을 입력하세요");
            //        break;
            //}

            //int inum2 = 90;

            //switch (inum2 % 5)
            //{
            //    case 1:
            //        Console.WriteLine("나머지의 값은 1입니다.");
            //        break;
            //    case 2:
            //        Console.WriteLine("나머지의 값은 2입니다.");
            //        break;
            //    case 3:
            //        Console.WriteLine("나머지의 값은 3입니다.");
            //        break;
            //    case 4:
            //        Console.WriteLine("나머지의 값은 4입니다.");
            //        break;
            //    default:
            //        Console.WriteLine("5의 배수입니다.");
            //        break;
            //}


            //for(int A=0; A<10; A++)
            //{
            //    Console.WriteLine("{0}", A);
            //}

            //int[] iArray = new int[5];   // 배열 모양 생성 = 배열 int 객체 방 5개 생성 // =를 통해 iArray   // 자바랑 동일한 개념임 
            // 왼쪽을 참조(reference)라고함. 
            //iArray[0] = 0;
            //iArray[1] = 1;
            //iArray[2] = 2;
            //iArray[3] = 3;
            //iArray[4] = 4;
            // 이렇게 한개씩 넣어야함

            //iArray = { 0,1,2,3,4}   // 이 구문처럼 한꺼번에 넣을수도 없다

            //int[] iArray;
            //iArray = new int[5] { 0, 1, 2, 3, 4 };
            ////참고로 C는 int iArray[5] 로 끝임, iArray라는 5개의 방이 생김

            //for(int i = 0; i<iArray.Length; ++i)
            //{
            //    Console.WriteLine(iArray[i]);
            //}
            //Console.WriteLine();

            //foreach (int i in iArray)
            //{
            //    Console.WriteLine(iArray[i]);
            //}


            //for(int i=0; i < 10; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    //if (i % 2 == 1)
            //    //                    break;
            //    Console.WriteLine("{0}", i);
            //}
            //Console.WriteLine();



            int a, b;
            float c = 0;
            Console.Write("첫번째 정수를 입력하세요 : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력하세요 : ");
            b = int.Parse(Console.ReadLine());

            try
            {
                c = a / b;
            }

            catch (Exception)
            {
                Console.WriteLine("변수의 값이 올바르지 않습니다.");
                Environment.Exit(0);
            }

            finally
            {
                Console.WriteLine("\n프로그램이 실행 되었습니다.");
            }

            Console.WriteLine("A/B값은 {0} 입니다.", c);
        }
    }
}

