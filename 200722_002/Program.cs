using System;
class Car
{
    public string name;
}
class TestCar
{
    private Car[] _array = new Car[5];
    public Car this[int Index]
    {
        get { return _array[Index]; }
        set { _array[Index] = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TestCar aTestCar = new TestCar();
        aTestCar[0] = new Car();
        aTestCar[1] = new Car();
        aTestCar[0].name = "비오는 날에는 소시지빵";
        aTestCar[1].name = "게임은 폭력적이다";
        Console.WriteLine(aTestCar[0].name);
    }
}


//class TestInt
//{
//    private int[] _array;
//    public TestInt(int size) // 값에따라 다른 값을 주는 생성자 만들기
//    {
//        _array = new int[size];
//    }
//    public int this[int Index]
//    {
//        get { return _array[Index]; }
//        set { _array[Index] = value; }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        TestInt aTestInt1 = new TestInt(10);
//        TestInt aTestInt2 = new TestInt(20);

//    }
//}

