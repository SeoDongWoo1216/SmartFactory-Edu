using System;
class Car // 아무것도 상속 안받았을때는 : Object 이 생략되어있다.
{
    String color;
    string name;
    string vender;
}
class Program
{
    static void Main(string[] args)
    {
        Car aCar = new Car();

        // 아무것도 안만들었는데 object가 들고있는 4가지의 메서드는 아래와같다.
        Console.WriteLine(aCar.Equals("test"));  // aCar는 Car클래스, "test"는 문자열이니까 일치하지않으므로 False를 출력
        
        //aCar.GetHashCode();
        //aCar.GetType();
        //aCar.ToString();
    }
}

