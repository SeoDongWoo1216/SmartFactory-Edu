﻿using System;
using System.Windows.Forms;
namespace _20200819_008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(txtkor.Text)
                + Convert.ToDouble(txtMath.Text)
                + Convert.ToDouble(txtEng.Text);

            double avg = sum / 3;

            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString();
        }
    }
}