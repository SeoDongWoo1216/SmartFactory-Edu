using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200525_007
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int iYear;
            Console.WriteLine("년도를 입력하세요");
            iYear = int.Parse(Console.ReadLine());

            if (((iYear%4 == 0)&&(iYear % 100 != 0)) || (iYear % 400 == 0))
            {
                Console.WriteLine("{0}는 윤년입니다.", iYear);
            }
            else
            {
                Console.WriteLine("{0}는 평년입니다.", iYear);
            }
            */

            /*
            int iNum;
            Console.Write("정수를 입력하세요. : ");
            iNum = int.Parse(Console.ReadLine());

            if(100 <= iNum)
            {
                Console.WriteLine("입력하신 숫자는 100보다 크거나 같습니다. ");
            }
            else
                    {
                Console.WriteLine("입력하신 숫자는 100보다 작습니다. ");
            }

            */

            /*
            int iNum1;
            int iNum2;
            int iMax;
            Console.WriteLine("정수1을 입력하세요");
            iNum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("정수2를 입력하세요");
            iNum2 = int.Parse(Console.ReadLine());

            // 입력받은 숫자 중 큰 숫자를 저장
            if (iNum1 < iNum2)
            {
                iMax = iNum2;
            }
            else
            {
                iMax = iNum1;
            }
            Console.WriteLine("iMax는 {0}입니다.", iMax);

            int iMax2;
            iMax2 = (iNum1 < iNum2) ? iNum2 : iNum1;
            // iNum2가 크다고 가정하는 경우 iMax2 = iNum2;
            // iNum1이 크다고 가정하는 경우 iMax2 = iNum1;
            Console.WriteLine("iMax2는 {0}입니다.", iMax2);

           */
            /*
            byte bNum = 100;
            Console.WriteLine(bNum);
            bNum = (byte)(bNum << 2);
            Console.WriteLine(bNum);
            */

            /*
            byte bNum = 3;
            Console.WriteLine(bNum);
            bNum = (byte)(bNum << 3);
            Console.WriteLine(bNum);
            */

            byte bNum1 = 0xAD;     // ox를 넣으면 16진수로 인식함
            byte bNum2 = 0x69;
            byte bNum3 = (byte)(bNum1 & bNum2);
            Console.WriteLine(bNum3);

        }
    }
}
