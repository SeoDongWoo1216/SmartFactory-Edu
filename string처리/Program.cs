using System;
using System.Text.RegularExpressions;

namespace string처리
{
    class Program
    {
        //static void Main1(string[] args)
        //{
        //    string email = "tester@test.com";
        //    Console.WriteLine(IsEmail(email));
        //}

        //private static bool IsEmail(string email)
        //{
        //    string[] parts = email.Split('@');
        //    if(parts.Length != 2)
        //    {
        //        return false;
        //    }

        //    if(IsAlphaNumeric(parts[0]) == false)
        //    {
        //        return false;
        //    }

        //    parts = parts[1].Split('.');
        //    if(parts.Length == 1)
        //    {
        //        return false;
        //    }

        //    foreach (var part in parts)
        //    {
        //        if(IsAlphaNumeric(part) == false)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //static bool IsAlphaNumeric(string text)
        //{
        //    foreach (var ch in text)
        //    {
        //        if(char.IsLetterOrDigit(ch) == false)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //================================================================

        //static void Main2(string[] args)
        //{
        //    string email = "tester@test.com";
        //    Console.WriteLine(IsEmail2(email));
        //}

        //private static bool IsEmail2(string email)
        //{
        //    Regex regex =
        //        new Regex(@"^([0-9a-zA-Z]+)@([0-9a-zA-Z]+)(\.[0-9a-zA-Z]+){1,}$");
        //    return regex.IsMatch(email);
        //}

        static void Main(string[] args)
        {
            string txt = "Hello, World! Welcome to my world!";

            Regex regex = new Regex("world", RegexOptions.IgnoreCase);
            string result = regex.Replace(txt, funcMatch);

            Console.WriteLine(result);
        }

        private static string funcMatch(Match match)
        {
            return "Universe";
        }
    }
}
