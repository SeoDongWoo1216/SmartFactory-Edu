using System;
class Coordinate
{
    public int x;
    public int y;
}
class Program
{
    static void Main1(string[] args)
    {
        //Coordinate c1 = new Coordinate();
        //Coordinate c2 = new Coordinate();

        //c1.x = 1;
        //c1.x = 2;
        //c2.x = 1;
        //c2.x = 2;

        //Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
        //Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);

        //if (c1 == c2) // 주소비교
        //{
        //    Console.WriteLine("같다");
        //}
        //else
        //{
        //    Console.WriteLine("다르다");
        //}

        //c1 = c2; // 같은 주소로 만들어주자
        //if (c1 == c2)
        //{
        //    Console.WriteLine("같다");
        //}
        //else
        //{
        //    Console.WriteLine("다르다");
        //}

        //c1.x = 100;
        //Console.WriteLine("c1 = {0}, {1}", c1.x, c1.y);
        //Console.WriteLine("c2 = {0}, {1}", c2.x, c2.y);
    }



    static Coordinate test()
    {
        Coordinate temp = new Coordinate();

        return temp;
    }
    static void Main(string[] args)
    {
        //Coordinate c = new Coordinate();
        //c를 참조변수, 오른쪽을 객체
        //왼쪽이 스택, 오른쪽이 Heap

        Coordinate c = test();

        c.x = 1;  // heap영역의 x에다가 1을 넣어라.
        c.y = 2;
        Console.WriteLine("c = {0}, {1}", c.x, c.y);

        try  // C에는 try catch문이없어서 if문으로하는데, 나중에 프로그램짤때는 if문이 알고리즘을 위한건지, 예외를 잡는건지 헷갈려서 이것을 쓴다.
        {
            c = null;
            c.x = 1;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("\nc가 Null아니니?\n");
        }
        catch (Exception)
        {
            Console.WriteLine("일단 예외가 발생했단다");
        }
    }
}











