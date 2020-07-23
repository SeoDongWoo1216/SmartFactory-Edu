using System;
class Parent
{
    public virtual void Name()
    {
        Console.WriteLine("Parent");
    }
}


class Child : Parent
{
    public void Name()
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
        for (int i = 0; i < Array.Length; ++i)
        {
            Array[i].Name();
        }
//부모한테 Name(), 자식한테 Name()인 똑같은 메서드를 만들어서 사용하는 기법을 메서드 오버라이딩이라고한다. 라이딩을 라이트라고보고 덮어쓰는것을 생각해보자
//오버라이딩은 상속에서만 쓸 수 있다, 인자가 일치하는 경우
//오버로딩은 메서드이름은 똑같은데 인자가 다른것임. 생성자도 메서드이므로 생성자가 같은데 인자가 다르면 생성자 오버로딩이다.
//오버로딩은 인자만 다르면 쓸 수 있으므로 상속했을때(클래스가 다를때), 같은 클래스일때도 쓸 수 있다. 
//
//버츄얼을 쓰면 type을 체크하지않고 객체를 체크해서 객체에 맞춰서 호출된다.
//일단은! 버츄얼은 좋다.라고 생각하자..
//
    }
}