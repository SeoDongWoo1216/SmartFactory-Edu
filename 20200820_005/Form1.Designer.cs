namespace _20200820_005
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRand1 = new System.Windows.Forms.Label();
            this.lbRand2 = new System.Windows.Forms.Label();
            this.lbRand3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbStrike = new System.Windows.Forms.Label();
            this.lbBall = new System.Windows.Forms.Label();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "카운트";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCount.Location = new System.Drawing.Point(129, 77);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(0, 19);
            this.lbCount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(48, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "정답";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(48, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "입력";
            // 
            // lbRand1
            // 
            this.lbRand1.AutoSize = true;
            this.lbRand1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRand1.Location = new System.Drawing.Point(142, 136);
            this.lbRand1.Name = "lbRand1";
            this.lbRand1.Size = new System.Drawing.Size(20, 19);
            this.lbRand1.TabIndex = 4;
            this.lbRand1.Text = "?";
            // 
            // lbRand2
            // 
            this.lbRand2.AutoSize = true;
            this.lbRand2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRand2.Location = new System.Drawing.Point(230, 136);
            this.lbRand2.Name = "lbRand2";
            this.lbRand2.Size = new System.Drawing.Size(20, 19);
            this.lbRand2.TabIndex = 5;
            this.lbRand2.Text = "?";
            // 
            // lbRand3
            // 
            this.lbRand3.AutoSize = true;
            this.lbRand3.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRand3.Location = new System.Drawing.Point(318, 136);
            this.lbRand3.Name = "lbRand3";
            this.lbRand3.Size = new System.Drawing.Size(20, 19);
            this.lbRand3.TabIndex = 6;
            this.lbRand3.Text = "?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(33, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "스트라이크";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(63, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "볼";
            // 
            // lbStrike
            // 
            this.lbStrike.AutoSize = true;
            this.lbStrike.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbStrike.Location = new System.Drawing.Point(163, 234);
            this.lbStrike.Name = "lbStrike";
            this.lbStrike.Size = new System.Drawing.Size(0, 19);
            this.lbStrike.TabIndex = 10;
            // 
            // lbBall
            // 
            this.lbBall.AutoSize = true;
            this.lbBall.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBall.Location = new System.Drawing.Point(163, 282);
            this.lbBall.Name = "lbBall";
            this.lbBall.Size = new System.Drawing.Size(0, 19);
            this.lbBall.TabIndex = 11;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(133, 177);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(41, 25);
            this.txtInput1.TabIndex = 12;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(218, 177);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(41, 25);
            this.txtInput2.TabIndex = 13;
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(312, 177);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.Size = new System.Drawing.Size(41, 25);
            this.txtInput3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "숫자야구";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "다시 시작";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(54, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "아웃";
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOut.Location = new System.Drawing.Point(163, 331);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(0, 19);
            this.lbOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInput3);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.lbBall);
            this.Controls.Add(this.lbStrike);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRand3);
            this.Controls.Add(this.lbRand2);
            this.Controls.Add(this.lbRand1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bulls and Cows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRand1;
        private System.Windows.Forms.Label lbRand2;
        private System.Windows.Forms.Label lbRand3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbStrike;
        private System.Windows.Forms.Label lbBall;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOut;
    }
}

