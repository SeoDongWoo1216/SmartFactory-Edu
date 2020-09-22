using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200821_003Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            lbRestaurant.Text = "오늘 점심은!! " + cb.SelectedItem.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                lbRestaurant.Text = comboBox1.Text + " Added!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
