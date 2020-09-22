using System;
using System.IO;
using System.Windows.Forms;

namespace _20200825_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader R = new StreamReader(@"C:\factory.txt");
            while (true)
            {
                string rName = R.ReadLine();
                if (null == rName)
                {
                    break;
                }
                string rPrice = R.ReadLine();
                productBindingSource.Add(
                    new Product() { Name = rName, Price = Convert.ToInt32(rPrice) }
                    );
            }


            //productBindingSource.Add(new Product() { Name = "고메", Price = 1000 });
            //productBindingSource.Add(new Product() { Name = "군고메", Price = 1300 });
            //productBindingSource.Add(new Product() { Name = "찐고메", Price = 1200 });
            //productBindingSource.Add(new Product() { Name = "짠고메", Price = 1500 });
            //productBindingSource.Add(new Product() { Name = "맛탕", Price = 1900 });
        }
    }
}
