namespace FactorySample
{
    partial class FactorySample
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GrdFactorytbl = new System.Windows.Forms.DataGridView();
            this.TxtYourPrice = new System.Windows.Forms.TextBox();
            this.CboCount = new System.Windows.Forms.ComboBox();
            this.CboFacLocation = new System.Windows.Forms.ComboBox();
            this.CboDivision = new System.Windows.Forms.ComboBox();
            this.CboFabric = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMatching = new System.Windows.Forms.Button();
            this.factoryDBDataSet = new FactorySample.FactoryDBDataSet();
            this.factorySampleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factorySampleTblTableAdapter = new FactorySample.FactoryDBDataSetTableAdapters.FactorySampleTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactorytbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorySampleTblBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GrdFactorytbl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtYourPrice);
            this.splitContainer1.Panel2.Controls.Add(this.CboCount);
            this.splitContainer1.Panel2.Controls.Add(this.CboFacLocation);
            this.splitContainer1.Panel2.Controls.Add(this.CboDivision);
            this.splitContainer1.Panel2.Controls.Add(this.CboFabric);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.CboSize);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.BtnMatching);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 0;
            // 
            // GrdFactorytbl
            // 
            this.GrdFactorytbl.AllowUserToAddRows = false;
            this.GrdFactorytbl.AllowUserToDeleteRows = false;
            this.GrdFactorytbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFactorytbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdFactorytbl.Location = new System.Drawing.Point(0, 0);
            this.GrdFactorytbl.Name = "GrdFactorytbl";
            this.GrdFactorytbl.ReadOnly = true;
            this.GrdFactorytbl.RowHeadersWidth = 51;
            this.GrdFactorytbl.RowTemplate.Height = 27;
            this.GrdFactorytbl.Size = new System.Drawing.Size(507, 450);
            this.GrdFactorytbl.TabIndex = 0;
            // 
            // TxtYourPrice
            // 
            this.TxtYourPrice.Location = new System.Drawing.Point(114, 272);
            this.TxtYourPrice.Name = "TxtYourPrice";
            this.TxtYourPrice.Size = new System.Drawing.Size(121, 25);
            this.TxtYourPrice.TabIndex = 3;
            // 
            // CboCount
            // 
            this.CboCount.FormattingEnabled = true;
            this.CboCount.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.CboCount.Location = new System.Drawing.Point(114, 225);
            this.CboCount.Name = "CboCount";
            this.CboCount.Size = new System.Drawing.Size(121, 23);
            this.CboCount.TabIndex = 2;
            // 
            // CboFacLocation
            // 
            this.CboFacLocation.FormattingEnabled = true;
            this.CboFacLocation.Items.AddRange(new object[] {
            "서울",
            "대구",
            "부산"});
            this.CboFacLocation.Location = new System.Drawing.Point(114, 184);
            this.CboFacLocation.Name = "CboFacLocation";
            this.CboFacLocation.Size = new System.Drawing.Size(121, 23);
            this.CboFacLocation.TabIndex = 2;
            // 
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.Items.AddRange(new object[] {
            "상의",
            "하의",
            "자켓"});
            this.CboDivision.Location = new System.Drawing.Point(114, 138);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.Size = new System.Drawing.Size(121, 23);
            this.CboDivision.TabIndex = 2;
            // 
            // CboFabric
            // 
            this.CboFabric.FormattingEnabled = true;
            this.CboFabric.Items.AddRange(new object[] {
            "면",
            "가죽",
            "린넨"});
            this.CboFabric.Location = new System.Drawing.Point(114, 83);
            this.CboFabric.Name = "CboFabric";
            this.CboFabric.Size = new System.Drawing.Size(121, 23);
            this.CboFabric.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "예상단가 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "개수 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "공장위치 : ";
            // 
            // CboSize
            // 
            this.CboSize.FormattingEnabled = true;
            this.CboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.CboSize.Location = new System.Drawing.Point(114, 37);
            this.CboSize.Name = "CboSize";
            this.CboSize.Size = new System.Drawing.Size(121, 23);
            this.CboSize.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "구분 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "재질 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "사이즈 : ";
            // 
            // BtnMatching
            // 
            this.BtnMatching.Location = new System.Drawing.Point(97, 324);
            this.BtnMatching.Name = "BtnMatching";
            this.BtnMatching.Size = new System.Drawing.Size(75, 23);
            this.BtnMatching.TabIndex = 0;
            this.BtnMatching.Text = "매칭";
            this.BtnMatching.UseVisualStyleBackColor = true;
            this.BtnMatching.Click += new System.EventHandler(this.button1_Click);
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factorySampleTblBindingSource
            // 
            this.factorySampleTblBindingSource.DataMember = "FactorySampleTbl";
            this.factorySampleTblBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // factorySampleTblTableAdapter
            // 
            this.factorySampleTblTableAdapter.ClearBeforeFill = true;
            // 
            // FactorySample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FactorySample";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFactorytbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorySampleTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView GrdFactorytbl;
        private System.Windows.Forms.ComboBox CboFabric;
        private System.Windows.Forms.ComboBox CboSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMatching;
        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource factorySampleTblBindingSource;
        private FactoryDBDataSetTableAdapters.FactorySampleTblTableAdapter factorySampleTblTableAdapter;
        private System.Windows.Forms.ComboBox CboFacLocation;
        private System.Windows.Forms.ComboBox CboDivision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYourPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboCount;
        private System.Windows.Forms.Label label6;
    }
}

