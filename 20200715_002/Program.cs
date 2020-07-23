using System;

//상속
class Parent
{
    public int iNum;
    public Parent(int iNum) // Parent의 디폴트 생성자
    {
        this.iNum = iNum;
        Console.WriteLine("Parent 클래스 생성자 : " + iNum);
    }
    ~Parent()
    {
        Console.WriteLine("Parent 클래스 소멸자");
    }
}
class Child : Parent
{
    public int iNum;
    public Child() : base(101)   // 원래는 : base()가 생략되어있다. base는 부모를 뜻한다.참고로 Java에서는 Super클래스라고 한다.
    // Child의 디폴트 생성자, 생성자는 보통 public을 붙여주는 것이 좋다.  
    {
        iNum = 200;
        Console.WriteLine("Child 클래스 생성자");
    }

    ~Child()  // 소멸자는 public을 붙이면 안된다.
    {
        Console.WriteLine("Child 클래스 소멸자");
    }
    public void Print()
    {
        Console.WriteLine("Child 클래스 iNum = " + base.iNum);  // 부모(base)클래스의 iNum호출
        Console.WriteLine("Child 클래스 iNum = " + this.iNum);  // 본인(자식)(this)클래스의 iNum호출
    }
}
class Program
{
    static void Main(string[] args)
    {
        Child aChild = new Child();
        aChild.Print();
    }
}

