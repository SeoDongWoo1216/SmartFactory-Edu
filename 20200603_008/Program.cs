using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_008
{
    class Market
    {
        public int iApple;
        public int iOrange;

        public override string ToString()
        {
            return "{iApple = " + iApple + ", iOrange = "+iOrange+"}";
        }
        public static Market operator +(Market Obj1, Market Obj2)
        {
            Market obj3 = new Market();
            obj3.iApple = Obj1.iApple + Obj2.iApple;
            obj3.iOrange = Obj1.iOrange + Obj2.iOrange;
            return obj3;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Market 가게1 = new Market();
            Market 가게2 = new Market();
            가게1.iApple = 10;
            가게1.iOrange = 10;
            가게2.iApple = 100;
            가게2.iOrange = 100;

            Market 가게3 = 가게1 + 가게2;
            Console.WriteLine("가게1" + 가게1);
            Console.WriteLine("가게2" + 가게2);
            Console.WriteLine("가게3" + 가게3);
        }
    }
}


/*
        public static Market operator +(Market Obj1, Market Obj2)
        {
            Console.WriteLine("1=========================");
            Market obj3 = new Market();
            Console.WriteLine("Obj1" + Obj1);
            Console.WriteLine("Obj2" + Obj2);
            Console.WriteLine("operator + 호출됨");
            Console.WriteLine("2=========================");
            return obj3;
        }
        */

// 이때 operator 메서드로가서 구문을 시작함
// -, *도 정의해주면 할 수 있다.
// 가게1에 10넣었고 가게2에 100을 넣었기 때문에 Obj1이 가게1, Obj2가 가게2인것을 알 수 있다.
// Tostring을 잘 만들줄알면 편리해지니까 잘 익혀두자

/*
 
 */
