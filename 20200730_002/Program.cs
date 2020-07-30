using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TcpListener aTcpListener = new TcpListener(IPAddress.Any, 7000);
        aTcpListener.Start();
        Console.WriteLine("서버가 시작되었습니다...");

        TcpClient aTcpClient = aTcpListener.AcceptTcpClient();
        Console.WriteLine("클라이언트가 접속되었습니다...");
        aTcpListener.Stop();

        NetworkStream aNetworkStream = aTcpClient.GetStream();
        byte[] Buffer = new byte[1024];
        aNetworkStream.Read(Buffer, 0, Buffer.Length);
        int BufferCount= aNetworkStream.Read(Buffer, 0, Buffer.Length);
        Console.WriteLine("클라이언트가 전송한 Data 크기 : " + BufferCount);
        Console.WriteLine("클라이언트가 전송한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));

        Buffer = Encoding.UTF8.GetBytes("자 이제 시작이야");
        aNetworkStream.Write(Buffer, 0, Buffer.Length);
        Console.WriteLine("클라이언트로 회신한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));

        Console.WriteLine("서버를 종료합니다...");
        aNetworkStream.Close();
        aTcpClient.Close();
    }
}