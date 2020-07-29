using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1");
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Console.WriteLine("2");
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        Console.WriteLine("3");
        Console.ReadLine();  // 프로그램을 멈추기위해서 ReadLine으로 블로킹을 할 수 있다.
        Console.WriteLine("4");

        Server.Close();
    }
}