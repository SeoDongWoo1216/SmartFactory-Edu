using System;
class Program
{


    /// <summary>
    /// ref, out 사용법
    /// </summary>
    /// ref를 사용하면 다른 메소드에서도 지역변수 값을 수정할 수 있음
    /// 

    //out사용이유
    //-특정 조건으로 초기화 시킬 때 사용
    //예를 들어 적과 싸울 때 적이 공격을 가하면 그때 hit 변수를 초기화하여 hp를 빼는데 사용

    //ref사용이유
    //-ref도 마찬가지로 특정 조건에 이미 생성된 변수값을 바꾸거나 수정할 때 사용
    //배열에 특정 인덱스 값을 수정할 때도 사용
    static void test1(int iArg1, ref int iArg2)
    {
        iArg1 = 100;
        iArg2 = 200;
    }
    static void test2(int iArg1, out int iArg2)
    {
        iArg1 = 100;
        iArg2 = 200;
    }
    static void Main(string[] args)
    {
        //int inum1 = 1000;
        //int inum2 = 2000;
        //test1(inum1, ref inum2); // iArg2 == inum2
        //Console.WriteLine(inum1);
        //Console.WriteLine(inum2);

        int inum1 = 1000;
        int inum2;
        test2(inum1, out inum2); // iArg2 == inum2
        Console.WriteLine(inum1);
        Console.WriteLine(inum2);
    }
}



// ref는 인자를 초기화해줘야 넘길 수 있다. 대신 의무사항이없다.
// out은 인자를 초기화안해도 넘길 수 있다. 대신 메서드쪽에서 새로운 값을 항상 넣어줘야한다.
// 결론은 상황에따라 써야한다.

//int iNum1 = 1000;
//int iNum2 = 2000;
//test1(iNum1, iNum2);

