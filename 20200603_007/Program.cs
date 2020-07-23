using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_007
{
    class Mathmatics
    {
        public int Abs(int value)
        {
            return (value >= 0) ? value : -value;
        }
        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }
        public decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathmatics math = new Mathmatics();
            Console.WriteLine(math.Abs(-5));
            Console.WriteLine(math.Abs(-10.052));
            Console.WriteLine(math.Abs(-20.01m));
        }
    }
}
