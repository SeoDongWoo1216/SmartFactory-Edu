using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200915_005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("새창 클릭");
        }
    }
}
