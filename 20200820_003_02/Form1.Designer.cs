namespace _20200820_003_02
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAlarmSet = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnSet);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TimePicker);
            this.tabPage1.Controls.Add(this.DatePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "알람 설정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblAlarmSet);
            this.tabPage2.Controls.Add(this.lblAlarm);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "디지털 시계";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(43, 58);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 25);
            this.DatePicker.TabIndex = 0;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(43, 136);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(200, 25);
            this.TimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "날짜 설정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "시간 설정";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(43, 203);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(99, 38);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "설정";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(148, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 38);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "해제";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAlarmSet
            // 
            this.lblAlarmSet.AutoSize = true;
            this.lblAlarmSet.Location = new System.Drawing.Point(38, 41);
            this.lblAlarmSet.Name = "lblAlarmSet";
            this.lblAlarmSet.Size = new System.Drawing.Size(72, 15);
            this.lblAlarmSet.TabIndex = 0;
            this.lblAlarmSet.Text = "알람 설정";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(38, 90);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(57, 15);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "Alarm : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Location = new System.Drawing.Point(41, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "현재시간";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTime.Location = new System.Drawing.Point(24, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 24);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 454);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblAlarmSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}

