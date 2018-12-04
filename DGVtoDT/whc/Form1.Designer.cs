namespace whc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工种DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业任务DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作业步骤DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.危害名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riskDBDataSet = new whc.riskDBDataSet();
            this.infoTableAdapter = new whc.riskDBDataSetTableAdapters.infoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1362, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.工种DataGridViewTextBoxColumn,
            this.作业任务DataGridViewTextBoxColumn,
            this.作业步骤DataGridViewTextBoxColumn,
            this.危害名称DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.infoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1306, 506);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // 工种DataGridViewTextBoxColumn
            // 
            this.工种DataGridViewTextBoxColumn.DataPropertyName = "工种";
            this.工种DataGridViewTextBoxColumn.HeaderText = "工种";
            this.工种DataGridViewTextBoxColumn.Name = "工种DataGridViewTextBoxColumn";
            // 
            // 作业任务DataGridViewTextBoxColumn
            // 
            this.作业任务DataGridViewTextBoxColumn.DataPropertyName = "作业任务";
            this.作业任务DataGridViewTextBoxColumn.HeaderText = "作业任务";
            this.作业任务DataGridViewTextBoxColumn.Name = "作业任务DataGridViewTextBoxColumn";
            // 
            // 作业步骤DataGridViewTextBoxColumn
            // 
            this.作业步骤DataGridViewTextBoxColumn.DataPropertyName = "作业步骤";
            this.作业步骤DataGridViewTextBoxColumn.HeaderText = "作业步骤";
            this.作业步骤DataGridViewTextBoxColumn.Name = "作业步骤DataGridViewTextBoxColumn";
            // 
            // 危害名称DataGridViewTextBoxColumn
            // 
            this.危害名称DataGridViewTextBoxColumn.DataPropertyName = "危害名称";
            this.危害名称DataGridViewTextBoxColumn.HeaderText = "危害名称";
            this.危害名称DataGridViewTextBoxColumn.Name = "危害名称DataGridViewTextBoxColumn";
            // 
            // infoBindingSource
            // 
            this.infoBindingSource.DataMember = "info";
            this.infoBindingSource.DataSource = this.riskDBDataSet;
            // 
            // riskDBDataSet
            // 
            this.riskDBDataSet.DataSetName = "riskDBDataSet";
            this.riskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableAdapter
            // 
            this.infoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1364, 462);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "导出表格到word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private riskDBDataSet riskDBDataSet;
        private System.Windows.Forms.BindingSource infoBindingSource;
        private riskDBDataSetTableAdapters.infoTableAdapter infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工种DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业任务DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作业步骤DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 危害名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

