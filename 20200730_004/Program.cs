using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
    //    Thread thread = Thread.CurrentThread;
    //    Console.WriteLine(thread.ThreadState);

        //Console.WriteLine(DateTime.Now);    // 출력 결과 : 현재 날짜, 현재 시간
        //Thread.Sleep(1000);                 // 1초 동안 스레드 중지
        //Console.WriteLine(DateTime.Now);    // 출력 결과 : 현재 날짜, 1초 지난 시간

        Thread t = new Thread(threadFunc);
        t.Start();
    }

    static void threadFunc()
    {
        Console.WriteLine("threadFunc run!");
    }

}

