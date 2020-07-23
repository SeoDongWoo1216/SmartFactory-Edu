using System;
// 추상메서드만 보관하고있는 클래스를 인터페이스 클래스라고한다.
// 설계 요약 설명하는 역할
//인터페이스를 왜 쓰는가? 다중상속처럼 쓸 수 있기때문.
interface test  
{
    //int iNum;   // 변수선언이 되지않는다.
    //void tt() { }  // 메서드 선언이 되지않는다.
    //public voidtt(){}  // 접근 제한자도 못쓴다.
    void tt();  
}

class Auto : test
{
    public void tt()
    {

    }
}






interface IMusician  // 상속받을때 구별하려고 I를 써주고 첫글자를 대문자로 해주는 것이 편하다.
{
    void Singing();   // 이렇게 선언해주면 IMusician을 상속받은애들은 무조건 Singing을 선언해야한다.
}

interface IActor  
{
    void Playing();   
}

class Musical : IMusician, IActor
{
    public void Singing()
    {
        Console.WriteLine("노래하다");
    }
    public void Playing()
    {
        Console.WriteLine("연기하다");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Musical aMusical = new Musical();
        aMusical.Playing();
        aMusical.Singing();
    }
}

