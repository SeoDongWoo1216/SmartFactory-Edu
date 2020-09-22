using System;
using System.Drawing;
using System.Windows.Forms;

namespace _20200819_001
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new Size(300, 200);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
