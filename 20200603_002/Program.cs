using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_002
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
            Mammal[] aMammal = new Mammal[4]
                                { new Mammal(),
                                  new Whale(),
                                  new Lion(),
                                  new Human() 
                                };
            foreach(Mammal Temp in aMammal)   // 객체가 100개가 되도 foreach 코드는 같다.
            {
                Temp.Move();
            }

            /*
            Mammal[] aMammal = new Mammal[4] 
                                { new Mammal(), 
                                  new Whale(), 
                                  new Lion(), 
                                  new Human() };
            aMammal[0].Move();
            aMammal[1].Move();
            aMammal[2].Move();
            aMammal[3].Move();
            */

            /*
            Mammal[] aMammal = new Mammal[4];   // 배열 4개 생성
            aMammal[0] = new Mammal();
            aMammal[1] = new Whale();
            aMammal[2] = new Lion();
            aMammal[3] = new Human();
            aMammal[0].Move();
            aMammal[1].Move();
            aMammal[2].Move();
            aMammal[3].Move();
            */
        }
    }
}
/*
 Mammal one = new Mammal();
            one.Move();

            Lion lion = new Lion();
            lion.Move();

            Whale whale = new Whale();
            whale.Move();

            Human human = new Human();
            human.Move();
 */
