using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200821_005
{
    
    class Program
    {
        static void Main(string[] args)  // Main1과 똑같이 출력되는 메서드
        {
            List<int> aList1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> aList2 = new List<int>() { };

            //var Fact = from Temp in aList1 select Temp;   // LinQ : 쿼리를 C#에서도 쓸 수 있는 기능
            //aList2 = Fact.ToList<int>();

            aList2 = (from Temp in aList1 select Temp).ToList<int>();  // 위의 두줄을 이 한줄로 줄일 수 있다
            Print(aList2);
        }
        static void Main1(string[] args)
        {
            List<int> aList1 = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            List<int> aList2 = new List<int>() { };

            foreach (var Temp in aList1)
            {
                aList2.Add(Temp);
            }

            Print(aList1);
            Print(aList2);
        }
        
        static void Print(List<int> aList)
        {
            foreach (var i in aList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
