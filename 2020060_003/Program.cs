using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020060_003
{
    public class Notebook
    {
        bool powerOn;
        public void Boot() 
        {
            Console.WriteLine("컴퓨터를 킵니다");
        }
        public void Shutdown()
        {
            Console.WriteLine("컴퓨터를 끕니다");
        }
        public void Reset() {
            Console.WriteLine("컴퓨터를 재부팅합니다");
        }
        bool fingerScan; // Notebook 특화 멤버 필드 추가
        public bool HasFingerScanDevice() // Notebook 특화 멤버 메서드 추가
        {
            return fingerScan;
        }
    }
    public class Desktop
    {
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
    }

    public class Netbook
        {
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================= 노트북 ===============");
            Notebook aNoteBook = new Notebook();
            aNoteBook.Boot();
            aNoteBook.Reset();
            aNoteBook.Shutdown();
            Console.WriteLine("================= 데스크탑 =============");
            Desktop aDesktop = new Desktop();
            aDesktop.Boot();
            aDesktop.Reset();
            aDesktop.Shutdown();
            Console.WriteLine("================= 넷북 =================");
            Netbook aNetbook = new Netbook();
            aNetbook.Boot();
            aNetbook.Reset();
            aNetbook.Shutdown();
            Console.WriteLine();
        }
    }
}