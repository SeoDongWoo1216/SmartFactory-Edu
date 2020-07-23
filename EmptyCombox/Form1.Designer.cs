namespace EmptyCombox
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboFabric = new System.Windows.Forms.ComboBox();
            this.CboDivision = new System.Windows.Forms.ComboBox();
            this.BtnMatching = new System.Windows.Forms.Button();
            this.GrdFactorytbl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactorytbl)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CboFabric);
            this.splitContainer1.Panel1.Controls.Add(this.CboDivision);
            this.splitContainer1.Panel1.Controls.Add(this.BtnMatching);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GrdFactorytbl);
            this.splitContainer1.Size = new System.Drawing.Size(693, 337);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "구분";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "재질 : ";
            // 
            // CboFabric
            // 
            this.CboFabric.FormattingEnabled = true;
            this.CboFabric.Items.AddRange(new object[] {
            "면",
            "린넨",
            "데님"});
            this.CboFabric.Location = new System.Drawing.Point(93, 73);
            this.CboFabric.Name = "CboFabric";
            this.CboFabric.Size = new System.Drawing.Size(121, 23);
            this.CboFabric.TabIndex = 4;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.Items.AddRange(new object[] {
            "상의",
            "하의",
            "자켓"});
            this.CboDivision.Location = new System.Drawing.Point(93, 157);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(121, 23);
            this.CboDivision.TabIndex = 5;
            // 
            // BtnMatching
            // 
            this.BtnMatching.Location = new System.Drawing.Point(72, 231);
            this.BtnMatching.Name = "BtnMatching";
            this.BtnMatching.Size = new System.Drawing.Size(75, 23);
            this.BtnMatching.TabIndex = 3;
            this.BtnMatching.Text = "매칭";
            this.BtnMatching.UseVisualStyleBackColor = true;
            // 
            // GrdFactorytbl
            // 
            this.GrdFactorytbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFactorytbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdFactorytbl.Location = new System.Drawing.Point(0, 0);
            this.GrdFactorytbl.Name = "GrdFactorytbl";
            this.GrdFactorytbl.RowHeadersWidth = 51;
            this.GrdFactorytbl.RowTemplate.Height = 27;
            this.GrdFactorytbl.Size = new System.Drawing.Size(458, 337);
            this.GrdFactorytbl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 337);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactorytbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboFabric;
        private System.Windows.Forms.ComboBox CboDivision;
        private System.Windows.Forms.Button BtnMatching;
        private System.Windows.Forms.DataGridView GrdFactorytbl;
    }
}

