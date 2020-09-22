using System;
using System.Collections.Generic;
namespace _20200821_002
{
    class Program
    {
        class Fact : IComparable
        {
            public string Name;
            public int Age;
            public string Gender;

            public int CompareTo(object obj)
            {
                // throw new NotImplementedException();  // 메서드를 생성했는데 자동으로 생성된 코드이다.
                // 까먹고 코드를 안짜는 것을 방지해서 오류를 내는 코드이다.
                // 반드시 NotImplementedException  를 지우고 코드를 짜야한다.

                Fact aFact = (Fact)obj;
                return this.Age.CompareTo(aFact.Age);

                //return Age.CompareTo(((Fact)obj).Age);
            }

            public override string ToString()
            {
                return string.Format($"[{Name},{Age},{Gender}]");
            } 
        }
        static void Main(string[] args)
        {
            List<Fact> aList = new List<Fact>();
            Fact Temp = new Fact();
            Temp.Name = "그놈";
            Temp.Age = 50;
            Temp.Gender = "남자";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.Name = "그녀";
            Temp.Age = 22;
            Temp.Gender = "여자";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.Name = "그놈";
            Temp.Age = 28;
            Temp.Gender = "남자";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.Name = "그녀";
            Temp.Age = 39;
            Temp.Gender = "여자";
            aList.Add(Temp);

            Temp = new Fact();
            Temp.Name = "그녀";
            Temp.Age = 31;
            Temp.Gender = "여자";
            aList.Add(Temp);

            foreach (var vTemp in aList)
           {
                Console.WriteLine(vTemp);
           }

            Console.WriteLine();
            aList.Sort();
            foreach (var vTemp in aList)
            {
                Console.WriteLine(vTemp);
            }
        }
    }
}
