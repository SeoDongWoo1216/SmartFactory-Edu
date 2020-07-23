using System;
class Program
{
    class Car
    {
        const int iNum1 = 10; // 한번 대입하면 값을 바꿀수가없는것이 const (수정의 여지가 아예없다, 파일로 만드는순간(컴파일할때) 값이 정해져있음)
        readonly int iNum2;  // 바꿀수없고 읽을수만있는 readonly (초창기 값을 넣을때까지는 수정의 여지가 있음->초반에 여지가있다는 뜻, 생성자 호출때 바꿀수있다)
        // iNum2는 만약 인자로 받으면 생성할때 값을 한번 바꿀 수 있다, (실행할때 값이 고정되는 친구들)

        string _color;
        string _vender;
        string _name;

        public string name
        {
            //프로퍼티
            get
            {
                return _name;
            }
            set  // set에는 value만 써야함.
            {
                //name = "Auto : " + name;
                this._name = value;
            }
        }

        public string GetName()
        {
            return _name;   // 반환 name이 문자열이므로 반환형도 string으로 void에서 바꿔준다.
        }
        public void SetName(string name) // 데이터를 간접적으로 접근하게해주는 메서드
        {
            name = "Auto : " + name;
            this._name = name;
        }

        public void Print()
        {
            //iNum2 = 200; // 값이 대입되지않음
            Console.WriteLine("[{0}],[{1}],[{2}]", _name, _vender, _color);
        }
        public Car() // 디폴트 생성자
        {
            Console.WriteLine("Car 디폴트 생성자 호출");
        }

        //생성자 오버로딩 : 이름은 같은데 인자가 다를때 오버로딩이라 부름.
        public Car(string name) 
        : this(name, "", null)  // 초기화 목록 : 내안의 내부를 실행하기전에 다른 애의 내부를 호출해달라 -> 코드의 중복을 없애줄 수 있다.
        // ""랑 null은 같은 뜻임
        {
            ////name = name;     // 인자랑 위에서 선언한 변수의 이름이 같다고 오류가 뜰 수 있다.
            //this.name = name;   // 이 클래스 안에서의 name을 구분짓기위해 this를 입력해준다.
            //Console.WriteLine("Car 생성자 호출");
        }

        public Car(string name, string vender) 
        : this(name, vender, "")
        {
            // 초기화 목록을 사용했기때문에 코드가 필요없다.(위에 name 구문도 마찬가지)
        }

        public Car(string name, string vender, string color) // 생성자 오버로딩
        {
            this._color = color;
            this._name = name;
            this._vender = vender;
            Console.WriteLine("Car 생성자 호출");
        }

        ~Car()
        {
            Console.WriteLine("Car 소멸자 호출");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("1========================");

        Car aCar = new Car("케이파이브","","");
        new Car();

        Console.WriteLine("2========================");
        //메서드 사용
        aCar.Print();
        aCar.SetName("비안츠");  // public string name으로 데이터를 가져올 수 있지만, 데이터를 간접적으로 접근하게하기위해 메서드를 사용한다.
        aCar.Print();
        string name = aCar.GetName();
        Console.WriteLine("읽어온 값은 " + name + " 입니다");

        Console.WriteLine("3========================");
        //프로퍼티 사용
        aCar.name = "람보르니";
        aCar.Print();
        name = aCar.name;
        Console.WriteLine("읽어온 값은 " + name + " 입니다");
        Console.WriteLine("4========================");
    }
}