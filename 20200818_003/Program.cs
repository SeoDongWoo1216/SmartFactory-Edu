using System;
class Program
{
    static void ArrayPrint<T>(T[] Num)
    {
        for (int Temp = 0; Temp < Num.Length; ++Temp)
        {
         Console.Write("{0}  ", Num[Temp]);
        }
        Console.WriteLine();
    }
    static void ArrayCopy<T>(T[] Dst, T[] Src)
    {
        for (int Temp = 0; Temp < Dst.Length; ++Temp)
        {
            Dst[Temp] = Src[Temp];
        }
    }
    //static void ArrayIntCopy(int[] Dst, int[] Src)
    //{
    //    for(int Temp = 0; Temp < Dst.Length; ++Temp)
    //    {
    //        Dst[Temp] = Src[Temp];
    //    }
    //}

    //static void ArraydoubleCopy(double[] Dst, double[] Src)
    //{
    //    for (int Temp = 0; Temp < Dst.Length; ++Temp)
    //    {
    //        Dst[Temp] = Src[Temp];
    //    }
    //}
    static void Main(string[] args)
    {
        int[] ArrayInt1 = {2, 4, 6, 8}; // 힙영역에 만들어서 값을 넣은거임
        int[] ArrayInt2 = new int[4];   // 힙영역에 만들기만했고, 0으로 채워져있는거임.
        ArrayCopy<int>(ArrayInt2, ArrayInt1);
        ArrayPrint<int>(ArrayInt2);

        double[] Arraydouble1 = { 2.1, 4.1, 6.1, 8.1 };
        double[] Arraydouble2 = new double[4]; 
        ArrayCopy<double>(Arraydouble2, Arraydouble1);
        ArrayPrint<double>(Arraydouble2);
    }
}