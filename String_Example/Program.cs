using System;
class Program1
{
    static void Main1(string[] args)
    {
        string txt = "Hello World";
        Console.WriteLine(txt + " Contains(\"Hello\"): " + txt.Contains("Hello"));
        Console.WriteLine(txt + " Contains(\"Halo\"): " + txt.Contains("Halo"));
        Console.WriteLine();

        Console.WriteLine(txt + " EndsWith(\"World\"): " + txt.EndsWith("World"));
        Console.WriteLine(txt + "EndsWith(\"ello\"): " + txt.EndsWith("ello"));
        Console.WriteLine();

        Console.WriteLine(txt + " GetHashCode(): " + txt.GetHashCode());
        Console.WriteLine("Hello GetHashCode(): " + "Hello".GetHashCode());
        Console.WriteLine();

        Console.WriteLine(txt + " IndexOf(\"World\"): "+ txt.IndexOf("World"));
        Console.WriteLine(txt + " IndexOf(\"Halo\"): " + txt.IndexOf("Halo"));
        Console.WriteLine();

        Console.WriteLine(txt + " Replace(\"World\", \"\"): "+ txt.Replace("World", ""));
        Console.WriteLine(txt + " Replace('o', 't'): " + txt.Replace('o', 't'));
        Console.WriteLine();

        Console.Write(txt + " Split('o'): ");
        OutputArrayString(txt.Split('o'));
        Console.Write(txt + " Split(' '): ");
        OutputArrayString(txt.Split(' '));
        Console.WriteLine();

        Console.WriteLine(txt + " StartsWith(\"Hello\"): " + txt.StartsWith("Hello"));
        Console.WriteLine(txt + " StartsWith(\"ello\"): " + txt.StartsWith("ello"));
        Console.WriteLine();

        Console.WriteLine(txt + " Substring(1) : " + txt.Substring(1));
        Console.WriteLine(txt + "SubString(2, 3) : " + txt.Substring(2, 3));
        Console.WriteLine();

        Console.WriteLine(txt + " ToLower(): " + txt.ToLower());
        Console.WriteLine(txt + " ToUpper(): " + txt.ToUpper());
        Console.WriteLine();

        Console.WriteLine("\" Hello World \" Trim(): " + " Hello World ".Trim());
        Console.WriteLine(txt + "Trim('H'): " + txt.Trim('H'));
        Console.WriteLine(txt + " Trim('d'): " + txt.Trim('d'));
        Console.WriteLine(txt + " Trim('H', 'd'): " + txt.Trim('H', 'd'));
        Console.WriteLine();

        Console.WriteLine(txt + " Legnth: " + txt.Length);
        Console.WriteLine("Hello Length : " + "Hello".Length);
        Console.WriteLine();

        Console.WriteLine("Hello != World: " + ("Hello" != "World"));
        Console.WriteLine("Hello == World: " + ("Hello" == "World"));
        Console.WriteLine("Hello == HELLO: " + ("Hello" == "HELLO"));
        Console.WriteLine();
    }

    private static void OutputArrayString(string[] arr)
    {
        foreach(string txt in arr)
        {
            Console.Write(txt + ", ");
        }
        Console.WriteLine();
    }
}


class Program2
{
    static void Main2(string[] args)
    {
        string txt = "Hello World";
        Console.WriteLine(txt + " Endswith(\"WORLD\"): " + txt.EndsWith("WORLD", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine();

        Console.WriteLine(txt + " IndexOf(\"WORLD\"): " + txt.IndexOf("WORLD", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine();

        Console.WriteLine(txt + " StartsWith(\"HELLO\"): " + txt.StartsWith("HELLO", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine();
    }
}

class Program3
{
    static void Main3(string[] args)
    {
        string txt = "Hello";
        Console.WriteLine(txt + " == HELLO: " + (txt == "HELLO")); // 출력결과 : False
        Console.WriteLine(txt + " == HELLO: " + txt.Equals("HELLO", StringComparison.OrdinalIgnoreCase)); // 출력결과: True
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        //string txt = "Hello {0}: {1}";
        //string output = string.Format(txt, "World", "Anderson");
        //Console.WriteLine(output);

        //string txt1 = "{2} {0} == {0}: {1}";
        //Console.WriteLine(txt1, "Hello", "World", "Hi");

        //string txt2 = "{0} * {1} == {2}";
        //Console.WriteLine(txt2, 5, 6, 5 * 6);

        //string txt3 = "{0, -10} * {1} == {2, 10}";
        //Console.WriteLine(txt3, 5, 6, 5 * 6);

        string txt4 = "날짜 : {0, -20:D}, 판매 수량: {1, 15:N}";
        Console.WriteLine(txt4, DateTime.Now, 267);
    }
}