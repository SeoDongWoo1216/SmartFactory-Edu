using System;
using System.Collections.Generic;
namespace _20200821_001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Random r = new Random();

            PrintValues(a); // 정렬하기 전에 프린트를 호출해서 a에 저장된 값을 출력한다. 값을 넣지 않았으므로 Count와 capacity 속성의 값은 0이다.

            for (int i = 0; i < 10; i++)  // 10번 반복해서 a에 0~100까지의 랜덤 숫자를 저장한다.
                a.Add(r.Next(100));

            PrintValues(a); // 정렬하기전에 프린트메서드를 호출해서 a에 저장된값을 출력해본다. Count 속성은 10, capacity속성은 16으로 출력된다.

            a.Sort(); // a의 값을 정렬하고 프린트메서드로 a에 저장된 값을 출력한다.
            PrintValues(a);

            a.RemoveAt(3); // List<T>의 3번 인덱스의 값을 제거한다.
            PrintValues(a);  // 프린트메서드를 호출해서 a에 저장된 값을 출력한다.
            // Count = 9가되고 3번 인덱스값이 제거된 것을 확인할 수 있다. capacity는 변화가 없다.
        }

            private static void PrintValues(List<int> a)
        {
            Console.WriteLine("Print Values in List<int>");
            Console.WriteLine("  Count = {0}", a.Count);
            Console.WriteLine("  Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write("  {0}", i);
            Console.WriteLine();
        }
    }
}