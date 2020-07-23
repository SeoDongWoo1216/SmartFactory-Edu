using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200603_005
{
    public class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "X : " + x + ", Y : " + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point(5, 10);
            Console.WriteLine(pt.ToString());
        }
    }
}
