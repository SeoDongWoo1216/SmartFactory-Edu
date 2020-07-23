using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200528_001
{
    class Program
    {
        class Car    // 클래스안에 클래스도 만들 수 있다(inner class/이너 클래스라 부른다.)
        {         
            //상태정보
            
            public int ispeed;  //속도
            int iNum;   // 클래스변수

            public void Acc()   //클래스 가속하는 메서드
            {
                ispeed = ispeed + 10;  // 메서드 변수
                                   // 같은 클래스에서 변수선언이 되어있어서 변수선언 안해도 빨간줄이 뜨지않는다
                                   // 클래스 안에있는 애들끼리 변수를 공유한다
            }
            public void DeAcc()  // 감속하는 메서드
            {
                ispeed = ispeed - 10;
            }
            public void Status()
            {
                Console.WriteLine("현재속도는 {0}km입니다. ", ispeed);
            }
        }
        static void Main(string[] args)  
        {
            // 
            /*
            Car MyCar;    // 원래있던(int나 char같은거)게 아니고 사용자 정의 타입
            MyCar = new Car();  // 객체는 Heap영역에 만들어야하기때문에 new영역이 필요함
            MyCar.ispeed = 0;
            Console.WriteLine("현재속도는 {0}km입니다. ", MyCar.ispeed);
            // MyCar.ispeed = MyCar.ispeed + 10;       // 이렇게 해도되지만 클래스를 써먹어보자
            MyCar.Acc();       // 속도 증가 메소드
            MyCar.DeAcc();    // 속도 감소 메소드
            */

            // 중복된 코드를 모두 제거하고 객체지향으로 표현
            Car MyCar;  
            MyCar = new Car();  
            MyCar.ispeed = 0;
            MyCar.Status();
            MyCar.Acc();
            MyCar.Status();
            MyCar.DeAcc();
            MyCar.Status();
        }
    }
}
