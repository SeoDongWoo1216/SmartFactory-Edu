using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200529_001
{
    class Program
    {
        class Car
        {
            public int _iSpeed;
            public Car()    // 디폴트 생성자
            {
                _iSpeed = 0;
                Console.WriteLine("Car() 생성자 호출");
            }
            ~Car()
            {
                Console.WriteLine("Car() 생성자 호출 : {0}  (종료자) ", _iSpeed);
            }

            public Car(int iSpeed)
            {
                _iSpeed = iSpeed;
                Console.WriteLine("Car(int) 생성자 호출");
            }
         
            public void Acc()
            {
                _iSpeed = _iSpeed + 10;
            }

            public void DeAcc()
            {
                _iSpeed = _iSpeed - 10;
            }

            public void Status()
            {
                Console.WriteLine("현재 속도는 {0}Km입니다.", _iSpeed);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1=================");
            Car MyCar = new Car();
            MyCar.Status();
            Console.WriteLine("2=================");
            Car MyCar1 = new Car(100);
            MyCar1.Status();
            Console.WriteLine("3=================");
        }
    }
}