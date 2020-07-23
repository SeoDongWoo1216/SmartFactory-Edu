using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_TEST
{
    public class Person
    {
        string name;
        int age;
        string dept;
        public Person(string name, int age, string dept)
        {
            this.name = name;
            this.age = age;
            this.dept = dept;
        }
        public override string ToString()
        {
            return "성명 : " + name + "\n나이 : " + age + "\n부서 : " + dept;
        }
        virtual public void Print()
        {
            Console.WriteLine("회사원입니다.");
        }
    }
    public class Developer : Person
    {
        public Developer(string name, int age, string dept) : base(name, age, dept)
        {

        }
        override public void Print()
        {
            Console.WriteLine("개발자입니다.");
        }
    }
    public class Sales : Person
    {
        public Sales(string name, int age, string dept) : base(name, age, dept)
        {
        }
        override public void Print()
        {
            Console.WriteLine("세일즈맨입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("과정명 : 스마트팩토리 과정");
            Console.WriteLine("교과목 : C# OOP/자료구조");
            Console.WriteLine("응시일 : 2020.06.04.");
            Console.WriteLine("응시자 : 서동우\n");
            Person[] A = new Person[] { new Developer("홍길동", 27, "연구소" ), new Sales("고길동",25,"판매" ) };
            foreach (Person B in A)
            {
                Console.WriteLine(B);
                B.Print();
                Console.WriteLine();
            }
        }
  
    }
}
