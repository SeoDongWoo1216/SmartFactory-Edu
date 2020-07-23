using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_005
{
    class Book
    {
        public decimal isbn13;
        public Book(decimal isbn13)
        {
            this.isbn13 = isbn13;
        }
    }
    class EBook : Book
    {
        decimal isbn13;
        public EBook() : base(0)
        {
            this.isbn13 = base.isbn13;
        }
        public EBook(decimal isbn13) : base(isbn13) // 또는 이렇게 값을 연계하는 것도 가능하다
        {
            isbn13 = this.isbn13;  
            this.isbn13 = base.isbn13;
        } //자식은 this를 써서 접근, 부모는 base를 써서 접근
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
