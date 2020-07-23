using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_004
{
    class Car
    {
        int iSpeed;      // 속도
        string sColor;   // 색상
        string sName;    // 이름
        string sVender;  // 제조사
        public void Print()
        {
            Console.WriteLine("속  도 : {0}", iSpeed);
            Console.WriteLine("생  상 : {0}", sColor);
            Console.WriteLine("이  름 : {0}", sName);
            Console.WriteLine("제 조 사 : {0}", sVender);
            Console.WriteLine();
        }
        public Car()  // 디폴트 생성자
        {
            iSpeed = 0;
            sColor = "화이트";
            sName = "미정";
            sVender = "미정";
        }
        public Car(int iSpeed) 
        {
            this.iSpeed = iSpeed;  // 자기자신에게 넣고싶은데 컴파일 오류가 뜨는데 this를 적어주면 해결된다,
            sColor = "화이트";
            sName = "미정";
            sVender = "미정";
        }
        public Car(string sColor)
        {
            iSpeed = 0;
            this.sColor = sColor;
            sName = "미정";
            sVender = "미정";
        }
        public Car(string sColor, string sName)
        {
            iSpeed = 0;
            this.sColor = sColor;
            this.sName = sName;
            sVender = "미정";
        }
        public Car(string sColor, string sName, string sVender)
        {
            iSpeed = 0;
            this.sColor = sColor;
            this.sName = sName;
            this.sVender = sVender;
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
            Car aCar = new Car();
            aCar.Print();

            aCar = new Car(80);
            aCar.Print();

            aCar = new Car("빨강");
            aCar.Print();

            aCar = new Car("빨강", "그랑죠");
            aCar.Print();

            aCar = new Car("빨강", "그랑죠", "현다이");
            aCar.Print();
        }
    }
}
