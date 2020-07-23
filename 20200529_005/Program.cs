using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
class Person
{
    public string _name;
    public Person(string name)
    {
        _name = name;
        Console.WriteLine("ctor 실행");
    }
    static Person()
    {
        Console.WriteLine("cctor 실행");
    }
}
namespace _20200529_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("");
            Console.WriteLine("--------");
            Person person2 = new Person("");
        }
    }
}
    /* 출력결과
      cctor 실행
      cotr 실행
      --------
      cotr 실행
     */

