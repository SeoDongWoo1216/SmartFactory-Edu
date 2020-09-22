using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSDW
{
    class Program
    {
        static void Main(string[] args)
        {
            string SDW = "라즈베리파이DHT11제어";
            Console.WriteLine(SDW);
            string SDWSUB = SDW.Substring(4, 2);
            Console.WriteLine(SDWSUB);
            SDWSUB = SDWSUB.Insert(1, "서동우");
            Console.WriteLine(SDWSUB);
        }
    }
}
