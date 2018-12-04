namespace ExportData
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.信息通信班BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.riskDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riskDBDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.信息通信班BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.currencyBindingSource;
            this.comboBox1.DisplayMember = "货币名称";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 33);
            this.comboBox1.TabIndex = 0;
            // 
            // 信息通信班BindingSource
            // 
            this.信息通信班BindingSource.DataMember = "信息通信班";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 
            this.riskDBDataSet1BindingSource.Position = 0;
            // 
            // riskDBDataSet1BindingSource1
            // 
            this.riskDBDataSet1BindingSource1.Position = 0;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "currency";
            this.currencyBindingSource.DataSource = this.riskDBDataSet1BindingSource1;
            // 
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1167, 373);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2045, 998);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.信息通信班BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskDBDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource 信息通信班BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource riskDBDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource riskDBDataSet1BindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

