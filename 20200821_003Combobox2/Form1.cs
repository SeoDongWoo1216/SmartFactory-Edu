using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200821_003Combobox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(true == comboBox1.Items.Contains(textBox2.Text))
            {
                comboBox1.Items.Remove(textBox2.Text);
            }
        }
    }
}
