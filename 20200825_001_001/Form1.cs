using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace _20200825_001_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> aList = new List<Product>()
            {
                    new Product(){Name = "고메", Price = 1000 },
                    new Product(){Name = "군고메", Price = 1300  },
                    new Product(){Name = "찐고메", Price = 1200 },
                    new Product(){Name = "짠고메", Price = 1500  },
                    new Product(){Name = "맛탕", Price = 1900  },
            };
            aList.Sort();
            string result = "";
            foreach (var Temp in aList)
            {
                result += (Temp + "\n");
            }
            MessageBox.Show(result);
        }
    }
}