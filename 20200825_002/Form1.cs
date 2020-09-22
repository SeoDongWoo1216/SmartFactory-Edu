using System;
using System.IO;
using System.Windows.Forms;

namespace _20200825_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                throw new Exception();
            }
            catch(Exception error)
            {
                MessageBox.Show("예외 발생");
            }
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            StreamReader R = new StreamReader(@"c:\factory.txt");
            
            string readResult;
            while (true)
            {
                readResult = R.ReadLine();
                if (readResult == null)
                {
                    break;
                }
                MessageBox.Show(readResult);
            }

        }

        //    private void button1_Click1(object sender, EventArgs e)
        //{
        //    //File.WriteAllText("c:\factory.txt", "factory");
        //    //File.WriteAllText(@"c:\factory.txt", "factory");

        //    //string Temp = File.ReadAllText(@"c:\factory.txt");
        //    //MessageBox.Show(Temp);

        //    //MessageBox.Show(File.ReadAllText(@"c:\factory.txt"));  // 위의 두줄은 한줄로 표현

        //    int[] aint = new int[] {3,6,78,20,44 };
        //    StreamWriter W = new StreamWriter(@"c:\factory.txt");

        //    W.WriteLine("헬로우 월드");
        //    W.WriteLine("바이바이 월드");
        //    foreach (var Temp in aint)
        //    {
        //        W.Write(Temp + ":");
        //    }
        //    W.WriteLine();
        //    W.WriteLine("취업가능할까");
        //    W.Close();

        //}
    }
}