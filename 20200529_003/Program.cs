using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200529_003
{
    class Person
    {
        static int CountOfInstance;    // private 정적 필드
        public string _name;

        public Person(string name)
        {
            CountOfInstance ++; 
            _name = name;
        }
        static public void OutputCount()    // public 정적 메서드
        {
            Console.WriteLine(CountOfInstance); // 정적 메서드에서 정적 필드에 접근
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.OutputCount();     // 클래스 이름으로 정적 메서드 호출
            
            Person person1 = new Person("홍길동");
            Person person2 = new Person("홍길순");

            Person.OutputCount();  //  출력 결과 : 2
        }
    }
}
