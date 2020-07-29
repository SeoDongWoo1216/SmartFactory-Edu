// 클라이언트
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Server.Connect(new IPEndPoint(IPAddress.Parse("192.168.0.111"), 7000));

        byte[] Buffer = Encoding.UTF8.GetBytes("이제 집에 간다!!");  // 바이트 배열로 변환
        Server.Send(Buffer);   // 받은 문자열을 처리

        Buffer = new byte[1024];
        int Number = Server.Receive(Buffer);  // 받은 바이트 수를 반환(int형)
        Console.WriteLine(Number);
        Encoding.UTF8.GetString(Buffer, 0, Number);  // 스트링 객체로 변환
       
        Server.Close();
    }
}