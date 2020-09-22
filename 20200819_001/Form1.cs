using System.Drawing;
using System.Windows.Forms;

namespace _20200819_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.ClientSize = new Size(500, 500);

            Form f2 = new Form2();
            this.AddOwnedForm(f2);

            f2.Show();
        }
    }
}