using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_004
{
    class Car
    {
        int iSpeed;     // 속도
        string sColor;     // 색상
        string sName;      // 이름
        string sVender;    // 제조사

        public override string ToString()
        {
            return "속  도 : " + iSpeed
                + "\n색  상 : " + sColor
                + "\n이  름 : " + sName
                + "\n제조사 : " + sVender;
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public Car(int iSpeed, string sColor, string sName, string sVender)
        {
            this.iSpeed = iSpeed;
            this.sColor = sColor;
            this.sName = sName;
            this.sVender = sVender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car aCar = new Car(100, "빨캉", "그냥죠", "현다이");
            aCar.Print();
            Console.WriteLine(aCar);
        }
    }
}
