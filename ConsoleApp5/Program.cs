using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //DateTime before = DateTime.Now;
        //Sum();
        //DateTime after = DateTime.Now;

        //long gap = after.Ticks - before.Ticks;
        //Console.WriteLine("Total Ticks : " + gap);
        //Console.WriteLine("Millisecond: " + (gap / 10000));
        //Console.WriteLine("Second : " + (gap / 10000 / 1000));


        Stopwatch st = new Stopwatch();

        st.Start();
        Sum();
        st.Stop();

        // st.ElapsedTicks 속성은 구간 사이에 흐른 타이머의 틱(tick) 수
        Console.WriteLine("Total Ticks : " + st.ElapsedTicks);

        // st.ElapsedMilliseconds 속성은 구간 사이에 흐른 시간을 밀리초로 변환해준다.
        Console.WriteLine("Second : " + st.ElapsedMilliseconds);

        // Stop.Frequency 속성이 초당 흐른 틱수를 반환하므로,
        // ElapsedTicks에 대해 나눠주면 초 단위의 시간을 잴 수 있다.
        Console.WriteLine("Second: " + st.ElapsedTicks / Stopwatch.Frequency);
    }

    private static long Sum()
    {
        long sum = 0;

        for (int i = 0; i < 1000000; i++)
        {
            sum += i;
        }
        return sum;
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        //DateTime now = DateTime.Now;
//        //Console.WriteLine(now + ": " + now.Kind);

//        //DateTime utcNow = DateTime.UtcNow;
//        //Console.WriteLine(utcNow + ": " + utcNow.Kind);

//        //DateTime worldcup2002 = new DateTime(2002, 5, 31);
//        //Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

//        //worldcup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);
//        //Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);


//        DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
//        DateTime now = DateTime.Now;
//        Console.WriteLine("오늘 날짜: " + now);
//        Console.WriteLine();

//        TimeSpan gap = endOfYear - now;
//        Console.WriteLine("올해의 남은 날짜: " + gap.TotalDays);
//        Console.WriteLine("올해의 남은 시간: " + gap.TotalHours);
//        Console.WriteLine("올해의 남은 밀리초: " + gap.TotalMilliseconds);
//        Console.WriteLine("올해의 남은 분: " + gap.TotalMinutes);
//        Console.WriteLine("올해의 남은 초: " + gap.TotalSeconds);
//    }
//}