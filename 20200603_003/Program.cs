using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_003
{
    public class Computer { 
    public virtual void Boot()
    {
        Console.WriteLine("메인보드 켜기");
    }
    }
    public class Notebook : Computer
    {
        override public void Boot()
        {
            //Console.WriteLine("메인보드 켜기");
            base.Boot();
            Console.WriteLine("액정 화면 켜기");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
