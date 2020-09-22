using System;
class Tclass
{
    public int a; //100
    public int b; //101
    public string s;  //Hello

    public override string ToString()
    {
        return "[" + a + "]" + "["+ b +"]" + "[" + s + "]";
    }
}
struct Tstruct
{
    public int a; 
    public int b; 
    public string s;  
    public Tstruct(int Temp)
    {
        a = 100;
        b = 200;
        s = Temp.ToString();
    }

    public override string ToString()
    {
        return "[" + a + "]" + "[" + b + "]" + "[" + s + "]";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Tstruct aTstruct1 = new Tstruct();
        Console.WriteLine(aTstruct1);

        Tstruct aTstruct2 = new Tstruct(700);
        Console.WriteLine(aTstruct2);

    }
}


// 메인메서드 주석
//Tstruct aTstruct1 = new Tstruct();
// aTstruct1.a = 100;
// aTstruct1.b = 101;
// aTstruct1.s = "헬로";
// Console.WriteLine(aTstruct1);

// //구조체는 객체 생성안해도 쓸 수 있다. 대신, 변수에 대입을 해줘야한다.
// Tstruct aTstruct2;
// aTstruct2.a = 102;
// aTstruct2.b = 103;
// aTstruct2.s = "키티키티";
// Console.WriteLine(aTstruct2);

// Tclass aTclass1 = new Tclass();
// aTclass1.a = 100;
// aTclass1.b = 101;
// aTclass1.s = "헬로우 키티";
// Console.WriteLine(aTclass1);

// Tclass aTclass2 = new Tclass();
// aTclass2.a = 102;
// aTclass2.b = 103;
// aTclass2.s = "헬로 키티";
// Console.WriteLine(aTclass2);
// Console.WriteLine();

// aTstruct1 = aTstruct2;
// aTclass1 = aTclass2;
// Console.WriteLine(aTstruct1);
// Console.WriteLine(aTstruct2);
// Console.WriteLine(aTclass1);
// Console.WriteLine(aTclass2);
// Console.WriteLine();

// aTstruct1.a = 500;
// aTclass1.a = 500;
// Console.WriteLine(aTstruct1);
// Console.WriteLine(aTstruct2);
// Console.WriteLine(aTclass1);
// Console.WriteLine(aTclass2);