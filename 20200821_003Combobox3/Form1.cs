using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200821_003Combobox3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            factBindingSource.Add(new Fact() { Name = "그놈1", Age = 40, Gender = "여자"});
            factBindingSource.Add(new Fact() { Name = "그놈2", Age = 22, Gender = "여자" });
            factBindingSource.Add(new Fact() { Name = "그놈3", Age = 33, Gender = "여자" });
            factBindingSource.Add(new Fact() { Name = "그놈4", Age = 55, Gender = "여자" });
            factBindingSource.Add(new Fact() { Name = "그놈5", Age = 18, Gender = "여자" });
        }
    }
}
