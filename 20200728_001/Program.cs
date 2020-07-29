using System;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
        IPAddress ipAddr = IPAddress.Parse("202.179.177.21");
        Console.WriteLine(ipAddr);

        IPAddress ipAddr2 = new IPAddress(new byte[]{202, 179, 177, 21});
        Console.WriteLine(ipAddr2);

        IPHostEntry entry1 = Dns.GetHostEntry("andjjip.tistory.com");
        foreach (IPAddress ipAddress in entry1.AddressList)
        {
            Console.WriteLine(ipAddress);
        }
        Console.WriteLine();

        string myComputer = Dns.GetHostName();

        Console.WriteLine("컴퓨터 이름 : " + myComputer);

        IPHostEntry entry2 = Dns.GetHostEntry(myComputer);
        foreach (IPAddress iPAddress in entry2.AddressList)
        {
            Console.WriteLine(iPAddress.AddressFamily + ": " + iPAddress);
        }
    }
}