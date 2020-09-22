using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200821_002QueueCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Cow");
            que.Enqueue("Rabbit");
            PrintQueue("que: ", que);

            Console.WriteLine(" Edqueuing '{0}'", que.Dequeue());
            Console.WriteLine(" Peek: '{0}'", que.Peek());

            Queue<string> que2 = new Queue<string>(que.ToArray());
            PrintQueue("que2:", que2);

            string[] array = new string[que.Count];
            que.CopyTo(array, 0);
        }

        private static void PrintQueue(string v, Queue<string> que)
        {
            throw new NotImplementedException();
        }
    }
}
