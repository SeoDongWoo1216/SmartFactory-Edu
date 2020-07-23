using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200626
{
    class Program
    {
        static void Main(string[] args)
        {
            //double radius = 3.14;
            //Console.WriteLine("radius의 형 : {0}", radius.GetType()); 
            //Console.WriteLine("radius의 값 : {0}", radius.ToString()); // 아스키코드로 바꿔서 출력
            //Console.WriteLine();
            ////WriteLine 자체가 자동으로 Tostring으로 바꿔서 출력해주는것임
            //// \n, Line은 엔터의 효과를 가지고있다(개행)

            //string name = "이효리";

            //Console.WriteLine("name 형 : {0}", name.GetType());
            //Console.WriteLine("name 값 : {0}", name.ToString());
            //Console.WriteLine();

            //Console.WriteLine("raduus == name : {0}\n", name.Equals(radius));  // 서로 동일한 Type인지 확인하는 Equals
            //기본형의 기본적으로가지는것은 GetType, ToString, Equals가 있다를 기억하자
            //=======================================================================================

            //int intValue = 127;
            //long longValue = intValue;
            //Console.WriteLine("longValue = {0}\n", longValue);   // 암시적 형변환

            //=======================================================================================
            //long longValue2 = 32767;
            //int intValue2 = (int)longValue2;

            //Console.WriteLine("longValue2 = {0}\n", longValue2);

            //=======================================================================================

            //bool abool = !true;
            //Console.WriteLine(abool);

            //=======================================================================================

            //int aint = 0x12345678;
            //Console.WriteLine("{0:X8}", aint);
            //aint = ~aint;
            //Console.WriteLine("{0:X8}", aint);

            //=======================================================================================
            //int aint = 0x12345678;
            //Console.WriteLine("{0:X8}", aint);  // 8자리수만큼 출력
            //aint = ~aint;
            //Console.WriteLine("{0:X8}", aint);
            //aint = aint >> 4;
            //Console.WriteLine("{0:X8}", aint);  // 끝에 7이 있었는데 절벽에 떨어져서 없어짐, 빈칸은 양수일때 0을 채움
            //aint = aint << 4;
            //Console.WriteLine("{0:X8}", aint); // 왼쪽은 이 숫자가 음수니까 1로채우는데 가득 찬 1은 F니까 F로 채워진다

            //=======================================================================================

            //byte abyte1 = 0x3F;
            //byte abyte2 = 0xC1;
            //Console.WriteLine("{0:X2}", abyte1 & abyte2);
            //Console.WriteLine("{0:X2}", abyte1 | abyte2);
            //Console.WriteLine("{0:X2}", abyte1 ^ abyte2);

            //=======================================================================================

            //bool abool = !true;
            //Console.WriteLine("abool의 상태는 ★" + (abool ? "참":"거짓") + "★ 일껄요?");

            //=======================================================================================

            //int iNum = 100;
            //if (iNum < 500)
            //{
            //    Console.WriteLine("iNum은 500보다 작습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("iNum은 500보다 큽니다.");
            //}

            //=======================================================================================

            //int ipoint = 77;
            //string result;
            //if (ipoint >= 0 && ipoint <= 100)
            //{
            //    if (ipoint > 50)
            //    { 
            //        result = "Pass"; 
            //    }
            //    else 
            //    { 
            //        result = "Fail";
            //    }
            //    Console.WriteLine("결과 : " + result);
            //}
            //else
            //{
            //    Console.WriteLine("에러 : 범위를 벗어났습니다.");
            //}
            // if문은 항상 bool형으로 들어간다는 것에 주목해보자
            //=======================================================================================


        }
    }
}
