using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020060_005
{
    public class Computer
    {
        protected bool powerOn;
        public void Boot()
        {
            Console.WriteLine("컴퓨터를 킵니다");
        }
        public void Shutdown()
        {
            Console.WriteLine("컴퓨터를 끕니다");
        }
        public void Reset()
        {
            Console.WriteLine("컴퓨터를 재부팅합니다");
        }
        bool fingerScan; // Notebook 특화 멤버 필드 추가
        public bool HasFingerScanDevice() // Notebook 특화 멤버 메서드 추가
        {
            return fingerScan;
        }
    }
    public class Notebook : Computer
    {
    }
    public class Desktop : Computer
    {
    }
    public class Netbook : Computer
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Notebook MyNoteBook = new Notebook();
            Computer MyComputer = MyNoteBook;

            Computer pc1 = new Computer();
            Notebook nb1 = (Notebook)pc1;
            */
            /*
            Notebook notebook = new Notebook();
            Computer pc1 = notebook;

            Notebook note2 = (Notebook)pc1;
            */
            
            Computer pc1 = new Notebook();

            Notebook note2 = (Notebook)pc1;
        }
    }
}
