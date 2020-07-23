using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200529_004
{
    class Program
    {
        
        static int Main(string[] args)
        { // string[] args 사용방법
          //Console.WriteLine(args[0]);
          //Console.WriteLine(args[1]);



          //명령 실행시 매개 변수 개수를 인지하여 출력하는 반복문 작성
            /*int iCount;
            for(iCount = 0; iCount < args.Length; ++iCount)
            {
                Console.WriteLine("[{0}] : {1}", iCount, args[iCount]);
            }
            */

            foreach (string command in args)
            {
                Console.WriteLine(command);
            }
            return 0;   // 보통은 프로그램의 정상적인 종료를 나타내서 0을 써줌
        }    
     }
}
   