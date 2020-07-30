using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        TcpClient aTcpClient = new TcpClient("192.168.0.111", 7000); 
        Console.WriteLine("서버에 접속합니다.");

        NetworkStream aNetworkStream = aTcpClient.GetStream();

        byte[] Buffer = Encoding.UTF8.GetBytes("뇌는 장식입니다...");
        aNetworkStream.Read(Buffer, 0, Buffer.Length);
        Console.WriteLine("서버가 전송한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));

        Buffer = new byte[1024];
        int BufferCount = aNetworkStream.Read(Buffer, 0, Buffer.Length);
        Console.WriteLine("서버가 전송한 Data 크기 : " + BufferCount);
        Console.WriteLine("서버가 회신한 Data 내용 : " + Encoding.UTF8.GetString(Buffer));

        Console.WriteLine("클라이언트를 종료합니다.");
        aNetworkStream.Close();
        aTcpClient.Close();
    }
}