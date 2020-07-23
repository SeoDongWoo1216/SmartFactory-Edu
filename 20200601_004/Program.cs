using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020060_004
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
        void test()
        {// 첫번째로 본인 내부클래스에서 찾고, 두번째로 상속받은 클래스에서 찾는 원리
            powerOn = true;  
            Boot();      // 상속받은거써도 오류가 뜨지않는다.   
            Reset();
            Shutdown();
        }                                                      
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