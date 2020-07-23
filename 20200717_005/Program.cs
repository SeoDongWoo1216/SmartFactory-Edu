using System;
//class IndexerTest
//{
//    private Hashtable myFavorite = new Hashtable();
//    public string this[string kind]
//    {
//        get { return (string)myFavorite[kind]; }
//        set { myFavorite[kind] = value; }
//    }
//}
//public class Test 
//{ 
//    static void Main(string[] args)
//    {
//        IndexerTest it = new IndexerTest();
//        it["fruit"] = "apple";
//        it["color"] = "blue";
//        System.Console.WriteLine(it["fruit"]);
//        System.Console.WriteLine(it["color"]);
//    }
//}


class TestInt // 6개짜리 인덱서로 작성
{
    private int[] _array = new int[6];
    public int this[int Index]   // 메서드처럼 생각하면 반환값이 int이고 인자가 int Index로도 생각할 수 있다.
        // 인덱서 Indexer
    {
        get { return _array[Index]; }
        set { _array[Index] = value; }
    }
}
class Testarray
{
    private string[] _array = new string[5];
    public string this[int Index]  //this는 자기의 객체
    {
        get { return _array[Index]; }
        set { _array[Index] = value; }
    }
    static void Main(string[] args)
    {
        Testarray aTest = new Testarray();  // 일반 객체 만드는 것처럼 만듬

        aTest[0] = "할룽a";    // 선언을 안했는데 글자가 들어간다, 0은 위의 index에 넣어준다, value는 할룽이 들어간다
        aTest[1] = "할룽b";
        aTest[2] = "할룽c";
        aTest[3] = "할룽d";
        aTest[4] = "할룽e";
        Console.WriteLine(aTest[0]); // 테스트객체의 인덱스로 이동해서 0번의 get, _array[index]의 0번인 할룽이 리턴되면서 '할룽' 호출
        Console.WriteLine(aTest[2]);  // 할룽 c 출력
        //배열만 전문적으로 다루는 클래스를 만드는 것임
        Console.WriteLine();

        TestInt aTestInt = new TestInt();
        aTestInt[0] = 12;
        aTestInt[1] = 13;
        aTestInt[2] = 14;
        aTestInt[3] = 15;
        aTestInt[4] = 16;
        aTestInt[5] = 17;
        Console.WriteLine(aTestInt[0]);
        Console.WriteLine(aTestInt[2]);
        Console.WriteLine(aTestInt[4]);
        Console.WriteLine();  // cw를 누르고 탭탭을 눌러주면 콘솔라이트라인이 자동완성된다.
    }
}