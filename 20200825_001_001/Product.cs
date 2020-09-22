using System;
class Product : IComparable
{
        public string Name { get; set; }
        public int Price { get; set; }

    public override string ToString()
    {
        return Name + ":" + Price + "원" + "\n";
    }
    public int CompareTo(object obj)
    {
        return Name.CompareTo((obj as Product).Name); // string은 CompareTo를 내장하고있다
        // Product로 형변환을해서 . 을찍으면 종속되있는 Name을 선택할 수 있다

        //가격순으로 정렬해보자
       // return Price.CompareTo((obj as Product).Price);
    }
}
