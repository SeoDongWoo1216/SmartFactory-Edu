using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Box
{
    private int width;
    private int height;

    //생성자
    public Box(int width, int height)
    {
        if(width > 0 && height > 0)
        {
            this.width = width;
            this.height = height;
        }
        else
        {
            Console.WriteLine("너비와 높이는 자연수로 초기화해라!");
        }
    }

    // 인스턴스 메서드
    public int Area()
    {
        return this.width * this.height;
    }

    // 겟터(Getter)
    public int GetWidth() { return width; }
    public int GetHeight() { return height; }

    // 셋터(Setter)
    public void SetWidth(int width)
    {
        if(width > 0) { this.width = width; }
        else { Console.WriteLine("너비는 자연수를 입력해주세요"); }
    }


    static void Main(string[] args)
    {

    }
}

