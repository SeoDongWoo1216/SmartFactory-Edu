using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sokoban_003_Background
{
    public partial class Form1 : Form
    {
        int HumaniX;
        int HumaniY;
        int MoveUnit = 50;  // 한번 입력에 움직일 간격
        const int iWidth  = 50;  // 클라이언트 폼의 크기 변수
        const int iHeight = 50;
        const int iTileX  = 16;  
        const int iTileY  = 10;
        
        // Bitmap ImgGROUND;
        Bitmap HumanFB;
        Bitmap HumanR;
        Bitmap HumanL;

        public Form1()
        {
            InitializeComponent();
            HumaniX = 0;
            HumaniY = 0;

            this.ClientSize = new System.Drawing.Size(iWidth * iTileX, iHeight * iTileY); // 클라이언트 폼의 사이즈 지정 메서드
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Bitmap ImgGROUND = new Bitmap(Properties.Resources.GND);
            HumanFB = new Bitmap(Properties.Resources.HumanFB);
            HumanR = new Bitmap(Properties.Resources.HumanR);
            HumanL = new Bitmap(Properties.Resources.HumanL);

            e.Graphics.DrawImage(HumanFB, HumaniX, HumaniY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    HumaniX = HumaniX + MoveUnit;
                    HumanFB = HumanR;
                    break;
                case Keys.Left:
                    HumaniX = HumaniX - MoveUnit;
                    HumanFB = HumanL;
                    break;
                case Keys.Up:
                    HumaniY = HumaniY - MoveUnit;
                    break;
                case Keys.Down:
                    HumaniY = HumaniY + MoveUnit;
                    break;
                default:
                    return;
            }
            Invalidate();
        }
    }
}

/*
 이미지크기 = 50이하로 적당히
 길       : Road
 벽       : Wall
 캐릭터   : Human
 박스     : Box
 목표지점 : Point
 배경     : GMD (BackGround)
 
 */
