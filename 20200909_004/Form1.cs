using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _20200909_004
{
    public partial class Form1 : Form
    {
        //int[] iPrice;
        //string[] sName;
        List<int> BookPrice = new List<int>();
        List<string> BookName = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Book[] aBook = new Book[]
            {
                new Book("책1", 5900),
                new Book("책2", 6400),
                new Book("책3", 4500),
                new Book("책4", 8200),
                new Book("책5", 5400),
                new Book("책6", 3800),
                new Book("책7", 3200),
            };

            foreach (var Temp in aBook)  // var가 Book 타입으로 자동으로 바꿔준다
            {
                BookPrice.Add(Temp.Price);   // 리스트를 사용했기때문에 배열을 일일이 써줄필요가 없다
                BookName.Add(Temp.Name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //chart1.Series[0].Points.DataBindY(iPrice);
            //chart1.Series[0].Points.DataBindX(sName);
            chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            chart1.Series[0].IsValueShownAsLabel = true;  // 차트 하나하나의 값(책가격)표시
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "") 
            { 
            BookName.Add(textBox1.Text);
            BookPrice.Add(int.Parse(textBox2.Text));
            chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            }
            else
            {
                MessageBox.Show("책 제목과 가격을 입력해주세요");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                for (int i = 0; i < BookName.Count; i++)
                {
                    if (BookName[i] == textBox1.Text && BookPrice[i] == int.Parse(textBox2.Text))
                    {
                        BookPrice.RemoveAt(i);
                        BookName.RemoveAt(i);
                        break;
                    }
                }
                chart1.Series[0].Points.DataBindXY(BookName, BookPrice);
            }
            else
            {
                MessageBox.Show("책 제목과 가격을 입력해주세요");
            }
        }
    }
}
