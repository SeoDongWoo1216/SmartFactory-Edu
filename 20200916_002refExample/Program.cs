using System;
using System.Collections.Generic;
namespace _20200916_002
{
    class Program
    {
        delegate int ArraySort(Product T1, Product T2);
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static int ArraySortPrice(Product T1, Product T2)
        {
            return T1.Price.CompareTo(T2.Price);   // T1가격, T2가격을 비교해서 출력
           //return T1.Price.CompareTo(T2.Price) * (-1);  // (-1)를 곱함으로써 역순으로 출력
        }

        static int ArraySortName(Product T1, Product T2)
        {
            return T1.Name.CompareTo(T2.Name);
            //return T1.Name.CompareTo(T2.Name) *(-1); // 역순출력
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
        {
            new Product() { Name = "감자  ", Price = 500 },
            new Product() { Name = "사과  ", Price = 700 },
            new Product() { Name = "고구마", Price = 400 },
            new Product() { Name = "배추  ", Price = 600 },
            new Product() { Name = "상추  ", Price = 300 }
        };

            Console.WriteLine("가격순으로 정렬");
           // products.Sort(ArraySortPrice);
            //products.Sort(delegate (Product T1, Product T2)
            //{
            // return T1.Price.CompareTo(T2.Price);   
            //}
            //);

            products.Sort((T1, T2) =>
            {
                return T1.Price.CompareTo(T2.Price);
            });


            foreach (var Temp in products)
            {
                Console.WriteLine(Temp.Name + " " + ": " + Temp.Price);
            }
            Console.WriteLine();

            Console.WriteLine("이름순으로 정렬");
            //products.Sort(ArraySortName);
            //products.Sort(delegate(Product T1, Product T2)
            //{
            //    return T1.Name.CompareTo(T2.Name);
            //}
            //);
            products.Sort((T1, T2) =>
            {
                return T1.Name.CompareTo(T2.Name);
            });
            foreach (var Temp in products)
            {
                Console.WriteLine(Temp.Name + " " + ": " + Temp.Price);
            }
        }
    }
}