using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200714_002
{
    // 생성자 예제
    // 생성자 만드는법 : 메서드, 클래스이름과 같아야함(ex)메서드 이름이 Car)
    class Program
    {
        class Car
        {
            string color;
            string vender;  // 제조사
            string name;
            
            /*
            생성자
            1. 메서드이다.
            2. 클래스와 이름이 동일하다.
            3. 반환 타입이 존재하지 않는다.(void형이다)
            */
           
            public Car()   // 디폴트(기본) 생성자(인자가 없는 생성자)
            {
                Console.WriteLine("Car 디폴트 생성자 호출");
            }

            public Car(string name)   // 생성자 오버로딩(이름은 같은데 인자가 다름)
            {
                Console.WriteLine("Car 생성자 호출");
            }

            ~Car()
            {
                Console.WriteLine("Car 소멸자 호출");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1===========================");
            Car aCar = new Car("비엠따블유"); // new다음은 해당 객체의 생성자가 생성된다.
            // 인자 "비엠따블유"때문에 Car(string name) 호출
            new Car();  // 인자 없으니까 디폴트생성자 호출
            Console.WriteLine("2===========================");
            // 객체를 생성할때 1번만 호출된다.
        }
    }
}