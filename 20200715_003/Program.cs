using System;

//객체기반 호출
// Child객체니까 Child를 써라, GrandChild객체니까 GrandChild를 써라.363
class Parent
{
    public virtual void Name()
    {
        Console.WriteLine("Parent");
    }
}
class Child: Parent
{
    public override void Name()
    {
        Console.WriteLine("Child");
    }
}
class GrandChild : Child
{
    public override void Name()
    {
        Console.WriteLine("GrandChild");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Parent obj1 = new Parent();
        Parent obj2 = new Child();
        // Child obj2 = new Child();
        // GrandChild obj3 = new GrandChild();
        Parent obj3 = new GrandChild();
        obj1.Name();
        obj2.Name();
        obj3.Name();
        Console.WriteLine();

        Parent[] Array = new Parent[]   // new Parent[]에서 3개를 선언했으니 []안의 숫자를 생략해도 상관없다.
        {
            new Parent(),
            new Child(),
            new GrandChild()
        };
        for(int i = 0; i < Array.Length; ++i)
        {
            Array[i].Name();
        }
        

        // 배열을 만든 구문과 obj.Name()으로 선언한 구문의 결과값은 같다.
        // 만약 100개의 코드를 짠다고 가정해보자.
        // 배열코드는 배열 100개만 선언해주면 for문은 그대로 써도 상관이없지만,
        // obj.Name()코드는 1부터 100까지 객체선언도 해줘야하고 .Name()도 100개를 선언해줘야한다.
        
        // virtual을 안쓰면 참조변수의 타입기반으로 돌아간다.
        // 객체지향이기때문에 객체기반으로 돌릴꺼다.
    }
}