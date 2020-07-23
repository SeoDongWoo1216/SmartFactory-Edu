using System;
class Mammal
{
    public void Move()
    {
        Console.WriteLine("이동합니다");
    }
}

class Lion : Mammal
{
    public new void Move()
    {
        Console.WriteLine("네 발로 움직인다.");
    }
}
class Whale : Mammal
{
    public new void Move()
    {
        Console.WriteLine("수영한다.");
    }
}
class Human : Mammal
{
    public new void Move()
    {
        Console.WriteLine("두 발로 움직인다.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion();
        Mammal one = lion; // 부모타입으로 형변환
        one.Move();
    }
}



//Mammal one = new Mammal();
//one.Move();

//        Lion lion = new Lion();
//lion.Move();

//        Whale whale = new Whale();
//whale.Move();

//        Human human = new Human();
//human.Move();