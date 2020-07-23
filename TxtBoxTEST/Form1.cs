using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtBoxTEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Price = 0;

            int a = 0;   
            if ("면" == CboFabric.SelectedItem.ToString())
            {
                a = 100;

            }
            else if ("가죽" == CboFabric.SelectedItem.ToString())
            {
                a = 200;
            }
            else
            {
                a = 300;
            }


            int b = 0;
            if ("상의" == CboDivision.SelectedItem.ToString())
            {
                b = 500;
            }
            else if ("하의" == CboDivision.SelectedItem.ToString())
            {
                b = 600;
            }
            else
            {
                b = 700;
            }

            int c = a + b;

            int d;
            if ("100" == CboCount.SelectedItem.ToString())
            {
                d = 100;
            }
            else if ("200" == CboCount.SelectedItem.ToString())
            {
                d = 200;
            }
            else
            {
                d = 300;
            }


            Price = c * d;
            TxtPrice.Text = Price.ToString("#,###");
        }

    }
}
