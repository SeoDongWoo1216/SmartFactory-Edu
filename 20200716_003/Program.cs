// 추상메서드 예제
using System;
abstract class Musician  // 추상클래스(객체 생성할 수 없다.) : abstract 키워드에 선언
   // 미연 실수방지, 사용자가 강제한대로 구문을 작성해야함.
{
    public virtual void Name()
    {
        Console.WriteLine("뮤지션입니다.");
    }
   // public abstract void Instruments();  // 추상메서드(완성되지않는 메서드)
   public virtual void Instruments() // 추상메서드가 없다고해서 추상클래스가아니다. 는 아니다.
    // 추상메서드는 추상클래스안에서만 만들 수 있다. (추상클래스 내부에서만 선언할 수 있다)
    {

    }
}
class ViolinPlayer : Musician
{
    public override void Name()
    {
        Console.WriteLine("바이올린 연주자입니다.");
    }
    public override void Instruments()
    {
        Console.WriteLine("저는 바이올린인데요?");

    }
}
class PianoPlayer : Musician
{
    public override void Name()
    {
        Console.WriteLine("피아노 연주자입니다.");
    }
    public override void Instruments()
    {
        Console.WriteLine("저는 피아노인데요?");
    }
}
class FlutePlayer : Musician   // 악기 구현안하면 상속이 안된다.
{
    public override void Name()
    {
        Console.WriteLine("플루트 연주자입니다.");
    }
    public override void Instruments()
    {
        Console.WriteLine("저는 플루트인데요?");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Musician[] Array = new Musician[3];
        Array[0] = new ViolinPlayer();  // 왼쪽은 뮤지션객체, 오른쪽은 바이올린객체인데 오류가 안뜬다.
        Array[1] = new PianoPlayer();
        Array[2] = new FlutePlayer();
        for (int i = 0; i<Array.Length; ++i)
        {
            Array[i].Name();
            Array[i].Instruments();
            Console.WriteLine("********************");
        }
    }
}