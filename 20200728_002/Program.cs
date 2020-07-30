using System;
using System.Net;
using System.Net.Sockets;
class Program
{
    static void Main(string[] args)
    {
        Socket Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // 벽 콘센트 생성
        // 통신 방식이 TCP 방식의 형태, ip랑 port는 Bind에서 추가해서 묶어줌.
        Server.Bind(new IPEndPoint(IPAddress.Any, 7000));  // IpEndPoint는 Ip주소 + 포트를 가지고있다.(Ip번호 아무거나, 포트 7000번이 할당됨)
        //Server.Bind(new IPEndPoint(IPAddress.IPAddress.Parse("192.168.0.122"), 7000));   // 윗 줄이랑 마찬가지로 이렇게 구문을 작성할 수 있다.
        // Any로하면 편리하지만, 게임이나 회사등에서는 확실한 ip로 써야할 것이다.
        Server.Listen(100);

        Socket Client = Server.Accept();  // 여기서 실행화면이 대기걸린거임(블로킹 함수 <-> 논블로킹(콘솔라이트라인같은거))
        // 접속이 들어와야지 수락해준다. 
        Console.WriteLine("Client Incomming");

        byte[] Buffer = new byte[] { 65, 66, 67, 68 };
        Client.Send(Buffer);

        Client.Close();
        Server.Close();
    }
}