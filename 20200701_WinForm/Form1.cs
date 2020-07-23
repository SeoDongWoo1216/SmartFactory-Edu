using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200701_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class.  
            base.OnPaint(e);  // 가려지는 영역이 지나가면 글자가 지워지는데 그것을 다시 그려주는 것이 OnPaint

                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 버튼 누르면 안녕?을 출력
            Graphics agraphics = CreateGraphics();
            agraphics.DrawString("안녕?", Font, new SolidBrush(ForeColor), ClientRectangle);
        }
    }
}
