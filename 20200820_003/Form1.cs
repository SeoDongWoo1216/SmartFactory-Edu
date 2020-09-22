using System;
using System.Windows.Forms;
namespace _20200820_003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime selecetedDay = dateTimePicker1.Value;

            txtDates.Text = today.Subtract(selecetedDay).TotalDays.ToString("0");
        }
    }
}
