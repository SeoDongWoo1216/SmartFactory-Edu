
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string _name;

    public Person(string name)
    {
        _name = name;
        Console.WriteLine("일반 생성자");
    }

    static Person()
    {
        Console.WriteLine("스태틱 생성자");
    }
    public Person()
    {
        Console.WriteLine("디폴트 생성자");
    }
}

namespace _20200601_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("시작1");
            Person person1;
            Console.WriteLine("시작2");
            person1 = new Person();
            Console.WriteLine("시작3");
            Person person2 = new Person("키티 지옥");
            Console.WriteLine("시작4");
        }
    }
}