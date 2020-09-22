using System;


class Program
    {
    public static void solution(long n)
    {
        string a = n.ToString();
        char[] chr = a.ToCharArray();
        Array.Sort(chr);
        Array.Reverse(chr);
        Console.WriteLine(chr);
    }

    static void Main(string[] args)
    {
        long n = 51267;
        solution(n);
        //답은 76521
    }
}


/*
 * int[] a = { -1, -2, -3, -4 };
  double b = 0;
        for (int i =0; i< a.Length; i++)
        {
            b = b + a[i];
        }

        b = (b/a.Length);
        Console.WriteLine(b);
 */


/*
 public static int solution(int n)
    {
        int d = 0;
        while (n >= 10)
        {
            d += (n % 10);
            n = n / 10;
        }
        d = n + d;
        return d;
    }
 */

/*
 public static string solution(int a, int b)
    {
        string answer = "";
        int c = 0;
        for (int i = 1; i < a; i++)
        {
            if (i == 4 || i == 6 || i == 9 || i == 11)
            {
                c += 30;
            }
            else if (i == 2)
            {
                c += 29;
            }
            else
            {
                c += 31;
            }
        }
        int d = b + c;
        switch (d%7)
            {
                case 1:
                    answer = "FRI";
                break ;
                case 2:
                    answer = "SAT";
                break;
                case 3:
                    answer = "SUN";
                break;
                case 4:
                    answer = "MON";
                break;
                case 5:
                    answer = "TUE";
                break;
                case 6:
                    answer = "WED";
                break;
                case 0:
                    answer = "THU";
                break;
            }
        return answer;
 */
