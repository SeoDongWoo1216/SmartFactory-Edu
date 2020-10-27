using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        //    public static void solution(int a, int b)
        //    {
        //    long answer = 0;
        //    if(a == b)
        //    {
        //        Console.WriteLine(a);
        //    }
        //    else if (b < a)
        //    {
        //        for (int i = b; b <= a; b++)
        //        {
        //            answer = answer + b;
        //        }
        //        Console.WriteLine(answer);
        //    }
        //    else
        //    {
        //        for (int i = a; a <= b; a++)
        //        {
        //            answer = answer + a;
        //        }
        //        Console.WriteLine(answer);
        //    }
        //       // return answer;            
        //}
        

        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 2, 1, 3, 4, 1 };
            //solution(numbers);
            //객체는 foreach문으로 출력하는게 편함
            foreach (var item in solution(numbers))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //int a = 1000;
            //int b = 15;
            //solution(a, b);

        }
        public static int[] solution(int[] numbers)
        {
            //int a = numbers.Length;
            //List<int> Saveme = new List<int>();
            //for (int i =0; i < a-1; i++)
            //{
            //    for(int j = i+1; j<=a-1; ++j)
            //    {
            //        if (!Saveme.Contains(numbers[i] + numbers[j])) {
            //            Saveme.Add(numbers[i] + numbers[j]);
            //        }
            //    }
            //}
            //Saveme.Sort();
            //foreach (var item in Saveme)
            //{
            //    Console.WriteLine(item);
            //}
            //return Saveme.ToArray();

            Array.Sort(numbers);

            bool[] Saveme = new bool[numbers[numbers.Length - 1] + numbers[(numbers.Length - 2)]+1];
            List<int> Saveme2 = new List<int>();
            //int[] Saveme2 = new int[Saveme.Length];
            for(int i=0; i < numbers.Length - 1; i++)
            {
                for (int j= i+1; j<=numbers.Length-1; j++)
                {
                    int b = numbers[i] + numbers[j];
                    Saveme[b] = true;
                }
            }


            for (int i = 0; i<Saveme.Length; i++)
            {
                if(Saveme[i] == true)
                {
                    Saveme2.Add(i);
                }
            }
            //foreach (var Temp in Saveme)
            //{
            //    Console.WriteLine(Temp);
            //}
            return Saveme2.ToArray();

        
        }

    }
}
