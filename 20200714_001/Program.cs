using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car
{
    //속성(Attribute) : 변수 
    //속도(숫자:int)
    
    private int Speed;  // 변수에도 접근권한을 설정해줄 수 있다
    // Speed를 private하면 클래스 내부에서만 사용할 수 있으므로 직접적인 사용은 불가능하고
    // 간접적으로 Accel과 braek로 사용할 수 있다.
    private const int SpeedValue = 10;
    private const int SpeedLimit = 200;


    //행위(Behavior) : 메서드
    public void Run()
    {
        Console.WriteLine("달립니다.");
    }

    public void Accel()
    {
        Speed = Speed + SpeedValue;  // 위의 상수값을 바꾸면 저절로 바뀌도록 묶어준다
        if(Speed > SpeedLimit)
        {
            Speed = SpeedLimit;
        }
        Console.WriteLine("현재 속도는 {0}입니다.", Speed);
    }

    public void Break()
    {
        Speed = Speed - SpeedValue;
        if(Speed < 0)
        {
            Speed = 0;
        }
        Console.WriteLine("현재 속도는 {0}입니다.", Speed);
    }

}
    

public class Auto
 {
    static void Main(string[] args)
    {
        Car aCar = new Car();
        aCar.Accel();
        aCar.Accel();
        aCar.Accel();
        aCar.Accel();
        aCar.Break();
        aCar.Break();
        aCar.Break();
        aCar.Break();
        aCar.Run();
    }

    /*
    static void Main1(string[] args)
     {
        Car aCar;  // 객체를 가리키는 애를 선언
        aCar = new Car();
        // Heap메모리에 Car스타일의 object가 생성된 후, 대입연산자(=)로인해 Heap영역의 주소가 aCar로 전달
      
        aCar.Run();  // .을 찍어서 소속된 객체참조변수를 호출
        aCar.Speed = 0;  // 오류가뜨지만 public을 붙여주면 없어진다.

        Console.WriteLine($"aCar의 속도는 {aCar.Speed}입니다. ");  // C#에서만 있는 출력코드
        Console.WriteLine("aCar의 속도는 {0}입니다. ", aCar.Speed);  // 변수를 한번에 볼 수 있다
        Console.WriteLine("aCar의 속도는 " + aCar.Speed + "입니다. "); // 자바는 이거밖에 못쓴대
    }
    */
}