using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200601_003
{
    public class NoteBook
    {
        bool powerOn;
        public void Boot()
        {
            Console.WriteLine("컴퓨터 전원을 켭니다.");
        }
        public void Shutdown()
        {
            Console.WriteLine("컴퓨터 전원을 끕니다.");
        }
        public void Reset()
        {
            Console.WriteLine("컴퓨터를 재부팅 합니다.");
        }
    }
    public class Desktop
    {
        bool powerOn;
        public void Boot()
        {
            Console.WriteLine("컴퓨터 전원을 켭니다.");
        }
        public void Shutdown()
        {
            Console.WriteLine("컴퓨터 전원을 끕니다.");
        }
        public void Reset()
        {
            Console.WriteLine("컴퓨터를 재부팅 합니다.");
        }
    }
    public class Netbook
    {
        bool powerOn;
        public void Boot()
        {
            Console.WriteLine("컴퓨터 전원을 켭니다.");
        }
        public void Shutdown()
        {
            Console.WriteLine("컴퓨터 전원을 끕니다.");
        }
        public void Reset()
        {
            Console.WriteLine("컴퓨터를 재부팅 합니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================= 노트북 =================");
            NoteBook aNoteBook = new NoteBook();
            aNoteBook.Boot();
            aNoteBook.Reset();
            aNoteBook.Shutdown();
            Console.WriteLine("================= 데스크탑 =================");
            Desktop aDesktop = new Desktop();
            aDesktop.Boot();
            aDesktop.Reset();
            aDesktop.Shutdown();
            Console.WriteLine("================= 넷북 =================");
            Netbook aNetbook = new Netbook();
            aNetbook.Boot();
            aNetbook.Reset();
            aNetbook.Shutdown();
        }
    }
}