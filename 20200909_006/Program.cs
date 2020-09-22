using System;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        XElement aXElement = XElement.Load("http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=2653062000");
        //Console.WriteLine(aXElement);
        var XMLData = from Temp in aXElement.Descendants("data") select new Weather() { 
            Hour = Temp.Element("hour").Value, 
            Temp = Temp.Element("temp").Value, 
            WdKor = Temp.Element("wdKor").Value, 
            WfKor = Temp.Element("wfKor").Value
        };
        foreach (var Temp in XMLData)
        {
            Console.WriteLine(Temp);
        }
    }
}