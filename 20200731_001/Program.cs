using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new Thread(threadFrc1);
        Thread t2 = new Thread(threadFrc2);
        Thread t3 = new Thread(threadFrc3);
        t1.Start();  // 주 스레드가 실행할 명령어가 없으므로 주 스레드는 제거됨
        t2.Start();
        t3.Start();  


        Console.WriteLine("주 스레드 종료!");
    }

    static void threadFrc1()
    {
        Console.WriteLine("7초 후에 프로그램 종료");
        Thread.Sleep(1000 * 7);   // 10초 동안 실행 중지
                                   // 현재 주 스레드는 종료됐어도 t 스레드는 존속한다.
        Console.WriteLine("7초 스레드 종료!");
    }
    static void threadFrc2()
    {
        Console.WriteLine("5초 후에 프로그램 종료");
        Thread.Sleep(1000 * 5); 
        Console.WriteLine("5초 스레드 종료!");
    }
    static void threadFrc3()
    {
        Console.WriteLine("3초 후에 프로그램 종료");
        Thread.Sleep(1000 * 3);  
        Console.WriteLine("3초 스레드 종료!");
    }
}

