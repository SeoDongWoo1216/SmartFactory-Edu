//클라이언트
 using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.111"), 7000));

        byte[] Buffer = Encoding.UTF8.GetBytes("이제 집에 간다!!");
        Server.Send(Buffer);

        Buffer = new byte[1024];
        int Number = Server.Receive(Buffer);
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Number));

        Server.Close();
    }
}
 
