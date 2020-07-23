//객체의 형변환
using System;
class Vehicle
{
    public void test()
    {
        Console.WriteLine("비히클");
    }
}
class Car : Vehicle
{
    public new void test()
    {
        Console.WriteLine("카카카");
    }
}
class Program
{
    static void Main(string[] args)
    {
        object[] aObject = new Object[]
        {
            new Vehicle(),
            new Car(),
            new Vehicle(),
            new Car(),
            new Vehicle(),
            new Vehicle()
        };

        Car aCar;
        for(int i=0; i<aObject.Length; ++i)
        {
            if((aCar = aObject[i] as Car) == null)  // 
            {
                // Vehicle 객체인 경우
                Vehicle aVehicle = (Vehicle)aObject[i];
                Console.WriteLine("Vehicle 타입");
            }
            else
            {
                // Car 객체인 경우
                Console.WriteLine("Car 타입");
            }
            
            /*
             if((aCar = aObject[i] as Car) == null)
            aCar = aObject[i] as Car

            카 객체가 aObject에 있는 경우는
            aCar = aObject[i]
            카 객체가 aObject에 없는 경우는
            aCar = null.
            */
        }
    }
 }


//static void Main5(string[] args)
//{
//    //as로 문제를 해결해보자
//    //Vehicle aVehicle = new Vehicle(); // 이걸하면 aCar출력
//    Vehicle aVehicle = new Car(); // 이걸하면 null 받았습니다 출력
//    Car aCar = new Car();

//    aCar = aVehicle as Car;  // 명시적 형변환을 쓰지말고 as를 이용해서 하는 방법을

//    if (aCar == null)
//    {
//        Console.WriteLine("널 받았습니다.");
//    }
//    else
//    {
//        Console.WriteLine("aCar");
//    }
//}


//static void Main4(string[] args)
//{
//    Vehicle aVehicle = new Vehicle();
//    Car aCar = new Car();

//    if (aVehicle is Car)  // is를 이용해서 좌우를 비교해서 참인지 거짓인지 판별
//    {
//        aCar = (Car)aVehicle;
//    }
//    else
//    {
//        Console.WriteLine("aVehicle은 Car가 아닙니다.");
//    }
//}

//    static void Main3(string[] args)
//{
//    Vehicle[] array = new Vehicle[]
//    {
//        new Car(),
//        new Car(),
//        new Vehicle()
//    };

//    for (int i = 0; i < array.Length; ++i)
//    {
//        Car aCar = (Car)array[i];
//        Console.WriteLine(array[i]);

//    }
//}


//static void Main2(string[] args)
//{
//    try
//    {
//        Vehicle avehicle = new Vehicle();
//        Car aCar = new Car();

//        aCar = (Car)avehicle;  // Car가 없는데 넣어버리는 행위
//        aCar.test();
//    }
//    catch(Exception)
//    {
//        Console.WriteLine("짜잔~ 오류가 떴습니다");
//    }

//}


//static void Main1(string[] args)
//{
//    Vehicle vehicle = new Vehicle();
//    Car car = new Car();

//    Vehicle a = car;  // 묵시적/암시적/자동 형변환
//    Car b = (Car)a;   // 명시적/강제적/수동 형변환
//}

