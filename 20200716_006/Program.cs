using System;
class Engin
{
    string name;
    string vender;
    public Engin()
    {
        name = "휘발 V6";
        vender = "비엔츠";
    }
    public override string ToString()
    {
        string Temp = "["
                    + "{" + name + "},"
                    + "{" + vender + "}"
                    + "]";
        return Temp;
    }
}
class Car
{
    string name;
    string color;
    string vender;
    Engin aEngin;
    public Car()
    {
        name = "케이세븐";
        color = "빨간색";
        vender = "기아";
        aEngin = new Engin();
    }
    public override string ToString() // 변수들의 정보를 디버그로 확인할때 쓴다.
    {
        string Temp = "["
                     + "{" + name + "},"
                     + "{" + color + "},"
                     + "{" + vender + "}"
                     + "{" + aEngin + "}"
                     + "]";
        return Temp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car aCar = new Car();
        //Console.WriteLine(aCar.Equals("test")); // aCar의 객체와 "test"가 같냐?를 비교하는 메서드 : False가 출력
        //Console.WriteLine(aCar.GetHashCode()); // 단방향 함수, 민증번호같은거라고 생각하면됨.
        //aCar = new Car();
        //Console.WriteLine(aCar.GetHashCode());
        Console.WriteLine(aCar.GetType());  // Type을 알 수 있는 메서드
        Console.WriteLine(aCar.ToString());  // getType과 출력값이 Car로 같다.
        Console.WriteLine(aCar);  // 이렇게만쓰면 컴파일러가 ToString으로 인식해서 Car를 출력
    }
}