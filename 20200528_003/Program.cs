using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200528_003
{
    class Program
    {
        class Car
        {
            public int _iSpeed;
            public Car(int iSpeed)
            {
                _iSpeed = iSpeed;
                Console.WriteLine("Car 클래스 생성됨");
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
            Console.WriteLine("1==================");
            Car MyCar = new Car(3);
            MyCar.Status();
            Console.WriteLine("2==================");
            Car MyCar1 = new Car(100);
            MyCar1.Status();
            Console.WriteLine("3==================");
        }
    }
}
