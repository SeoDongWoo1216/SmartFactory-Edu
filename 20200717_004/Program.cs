
//프로퍼티예제
using System;
public class PropertyTest
{
    private string _name;
    private int _Readonly;
    private int _Writeonly;
    private static int _Static;

    public static int Static 
    {
        get { return _Static; }
        set { _Static = value; }
    } 

    public int Writeonly  // 외부에서 쓰게만 만드는거
    {
        set { _Writeonly = value; }
    }

    public int Readonly // 외부에서 읽게만 하는거
    {
        get { return _Readonly; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        PropertyTest pt = new PropertyTest();
        pt.Name = "헬로 키티";
        Console.WriteLine(pt.Name);
        Console.WriteLine(pt.Readonly);
        //pt.Readonly = 100;
        pt.Writeonly = 100;
        //Console.WriteLine(pt.Writeonly);
        PropertyTest.Static = 200;
        Console.WriteLine(PropertyTest.Static);
    }
}









////메모리 확인코드
//int iNum1 = 100; // 값타입 선언

//Object aObject = iNum1; // 객체 참조변수에 값을 넣는다?

//int iNum2 = (int)aObject; // 

//Console.WriteLine(iNum1);
//        Console.WriteLine(iNum2);
//        Console.WriteLine(aObject);

