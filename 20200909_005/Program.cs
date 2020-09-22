using System;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2653062000");   // 이거 선언하려면 using System.Xml.Linq; 을 선언해줘야한다.
        //Console.WriteLine(aXElement);
        var XMLData = from Temp in aXElement.Descendants("data") select Temp;
        //foreach (var Temp in XMLData)
        //{
        //    Console.WriteLine(Temp);
        //}
        foreach (var Temp in XMLData)
        {
            Console.Write(Temp.Element("hour").Value + "시\t");  // 태그의 내용을 추출
            Console.Write(Temp.Element("temp").Value + "℃\t");
            Console.Write(Temp.Element("wdKor").Value + "풍\t");
            Console.Write(Temp.Element("wfKor").Value + "\t");
            Console.WriteLine();
        }
    }
}

