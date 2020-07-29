//서버
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));
        // Any는 자동으로 PC의 IP 주소를 불러옴
        // Bind는 소켓(TCP가 들어있음)과 IP와 포트를 묶어줌
        Server.Listen(100);

        Socket Client = Server.Accept(); // 블로킹 함수 | 넌블로킹 
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[1024]; // Telnet은 2byte로 해석 못함 1byte ASCII코드로 해석
        int Number = Client.Receive(Buffer);
        Console.WriteLine(Encoding.UTF8.GetString(Buffer, 0, Number));
        Buffer = Encoding.UTF8.GetBytes("이제 집에 간다!!");
        Client.Send(Buffer);

        Client.Close();
        Server.Close();
    }
}