using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_001
{
    class Mammal
    {
        public virtual void Move()
        {
            Console.WriteLine("이동한다");
        }
    }
    class Lion : Mammal
    {
        public override void Move()
        { 
            Console.WriteLine("네 발로 움직인다.");
        }
    }
    class Whale : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("수영한다.");
        }
    }
    class Human : Mammal
    {
        public override void Move()
        {
            Console.WriteLine("두 발로 움직인다");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal aMammal = new Mammal();
            aMammal.Move();

            aMammal = new Lion(); 
            aMammal.Move();

            aMammal = new Whale();
            aMammal.Move();

            aMammal = new Human();
            aMammal.Move();
        }
}
}
// 아무것도 안적고 new를 적으면 부모꺼 호출, override적으면 자식꺼 호출
                                    // 아무것도 안적으면 new로 번역한다