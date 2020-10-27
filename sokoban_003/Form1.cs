using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_003
{
    public partial class Form1 : Form
    {
        int iX;
        int iY;
        const int iMoveUnit = 20;  // 프로그램 중간에 변하지 않음.(상수처리)
        public Form1()
        {
            iX = 0;
            iY = 0;
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Bitmap aBitmap = new Bitmap(Properties.Resources._1);
            e.Graphics.DrawImage(aBitmap, iX, iY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //++iX;
            //++iY;
           
            switch (e.KeyCode)
            {
                case Keys.Right:
                    iX += iMoveUnit;
                    break;
                case Keys.Left:
                    iX -= iMoveUnit;
                    break;
                case Keys.Up:
                    iY -= iMoveUnit;
                    break;
                case Keys.Down:
                    iY += iMoveUnit;
                    break;
                case Keys.Home:  // Home키를 누르면 위치 초기화
                    iX = 0;
                    iY = 0;
                    break;
                default:   // 방향키말고 다른 키를 누르면 Invalidate()를 호출하지않음
                    return; 
            }
            Invalidate();
        }
    }
}
