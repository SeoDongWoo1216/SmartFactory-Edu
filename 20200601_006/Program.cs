using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020060_006
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
        bool fingerScan; 
        public bool HasFingerScanDevice()
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
    public class DeviceManager
    {
        public void TurnOff(Computer device)
        {
            device.Shutdown();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            if(!(n is string))  // n이 string형이냐? (!는 반대연산자)
            {
                Console.WriteLine("변수 n은 string 타입이 아닙니다.");
            }

            string txt = "text"; 
            if(false == (txt is int))   // 변수 txt가 int형이냐?
            {
                Console.WriteLine("변수 txt는 int 타입이 아닙니다");
            }

        }
    }
}

/*
            Computer[] machines 
                = new Computer[]  { new Notebook(),    // 배열 선언
                                    new Desktop(),     // 암시적 형변환임
                                    new Netbook() };  
            DeviceManager aDevicemanager = new DeviceManager();
            */

/*
// 위에 주석처리된 배열구문 풀어서 쓴거
Computer[] machines = new Computer[3];   // 배열 3칸 만들기
machines[0] = new Notebook();
machines[1] = new Desktop();
machines[2] = new Netbook();
DeviceManager aDevicemanager = new DeviceManager();
                         // 참고로 int배열은 int[] iNum = new int[3];  이 끝이다
                         // Computer[] machines = new Computer[3];  랑 똑같은거임

foreach (Computer Temp in machines)     // foreach문으로 배열개수만큼 돌릴 수 있다
 {
      aDevicemanager.TurnOff(Temp); 


 }
*/


/*
             출력 결과
             컴퓨터를 끕니다
             컴퓨터를 끕니다
             컴퓨터를 끕니다
             */



/*
            Notebook aNoteBook = new Notebook(); // 노트북 객체 생성
            Desktop aDesktop = new Desktop();  // 데스크탑 객체 생성
            Netbook aNetBook = new Netbook();  // 넷북 객체 생성
            DeviceManager aDeviceManager = new DeviceManager();

            aDeviceManager.TurnOff(aNoteBook);
            aDeviceManager.TurnOff(aDesktop);
            aDeviceManager.TurnOff(aNetBook);
            */

