namespace IndexSeachingTest
{
    partial class InsertGridPrice
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
            this.button1 = new System.Windows.Forms.Button();
            this.GrdPriceTbl = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorySampleTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryDBDataSet = new IndexSeachingTest.FactoryDBDataSet();
            this.factorySampleTblTableAdapter = new IndexSeachingTest.FactoryDBDataSetTableAdapters.FactorySampleTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdPriceTbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorySampleTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GrdPriceTbl);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "평점순";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GrdPriceTbl
            // 
            this.GrdPriceTbl.AllowUserToAddRows = false;
            this.GrdPriceTbl.AllowUserToDeleteRows = false;
            this.GrdPriceTbl.AutoGenerateColumns = false;
            this.GrdPriceTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdPriceTbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.fabricDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.facLocationDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.GrdPriceTbl.DataSource = this.factorySampleTblBindingSource;
            this.GrdPriceTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdPriceTbl.Location = new System.Drawing.Point(0, 0);
            this.GrdPriceTbl.Name = "GrdPriceTbl";
            this.GrdPriceTbl.ReadOnly = true;
            this.GrdPriceTbl.RowHeadersWidth = 51;
            this.GrdPriceTbl.RowTemplate.Height = 27;
            this.GrdPriceTbl.Size = new System.Drawing.Size(530, 450);
            this.GrdPriceTbl.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabricDataGridViewTextBoxColumn
            // 
            this.fabricDataGridViewTextBoxColumn.DataPropertyName = "Fabric";
            this.fabricDataGridViewTextBoxColumn.HeaderText = "Fabric";
            this.fabricDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fabricDataGridViewTextBoxColumn.Name = "fabricDataGridViewTextBoxColumn";
            this.fabricDataGridViewTextBoxColumn.ReadOnly = true;
            this.fabricDataGridViewTextBoxColumn.Width = 125;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Width = 125;
            // 
            // facLocationDataGridViewTextBoxColumn
            // 
            this.facLocationDataGridViewTextBoxColumn.DataPropertyName = "FacLocation";
            this.facLocationDataGridViewTextBoxColumn.HeaderText = "FacLocation";
            this.facLocationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facLocationDataGridViewTextBoxColumn.Name = "facLocationDataGridViewTextBoxColumn";
            this.facLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.facLocationDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // factorySampleTblBindingSource
            // 
            this.factorySampleTblBindingSource.DataMember = "FactorySampleTbl";
            this.factorySampleTblBindingSource.DataSource = this.factoryDBDataSet;
            // 
            // factoryDBDataSet
            // 
            this.factoryDBDataSet.DataSetName = "FactoryDBDataSet";
            this.factoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factorySampleTblTableAdapter
            // 
            this.factorySampleTblTableAdapter.ClearBeforeFill = true;
            // 
            // InsertGridPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InsertGridPrice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InsertGridPrice_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdPriceTbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factorySampleTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GrdPriceTbl;
        private FactoryDBDataSet factoryDBDataSet;
        private System.Windows.Forms.BindingSource factorySampleTblBindingSource;
        private FactoryDBDataSetTableAdapters.FactorySampleTblTableAdapter factorySampleTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
    }
}

