// 델리게이트 : 메서드의 이름을 변수처럼 쓸수 있다.
using System;
class Program
{
    delegate int NewType(int Num);   // NewType의 이름을 가진 새로운 타입을 정의
    // 델리게이트를 위임, 대리자로도 부름

    static int OnePlus(int Num)
    {
        return Num + 1;
    }

    static int TenPlus(int Num)
    {
        return Num + 10;
    }

    static void Main(string[] args)
    {
        int TestNum = OnePlus(100);
        Console.WriteLine(TestNum);

        // NewType() 에 메서드 이름을 넣은것이 포인트!
        NewType aNewType = new NewType(OnePlus);   // aNewType과 onePlus는 같아지는 거임
        TestNum = aNewType(1000);  // aNewType이 OnePlus에 값을 받음
        Console.WriteLine(TestNum);


        aNewType = new NewType(TenPlus);
        TestNum = aNewType(1000);
        Console.WriteLine(TestNum);
    }
}

