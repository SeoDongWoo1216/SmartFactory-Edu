using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200529_002
{
    class Person
    {
        //public string _name;
        public static string _name;

        public Person(string name)
        {
            _name = name;
        }
        public void OutputYourName()
        {
            Console.WriteLine(_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("홍길동");
           // Person person;
            Person._name = "이순신";
            //person.OutputYourName();
            Console.WriteLine(Person._name);
            //Console.WriteLine(person._name);
        }
    }
}
