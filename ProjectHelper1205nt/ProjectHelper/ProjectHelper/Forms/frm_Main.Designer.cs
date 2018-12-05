namespace ProjectHelper.Forms
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btn_EditProject = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tSMItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_EditProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_ProjectEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Risk = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Data_Risk = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Data_Base = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Data_Members = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_EditProject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(101, 212);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.63636F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 275);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "方案编制";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMItem_File,
            this.tSMItem_EditProject,
            this.tSMItem_Risk,
            this.tSMItem_Data,
            this.tSMItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1483, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "文件";
            // 
            // Btn_EditProject
            // 
            this.Btn_EditProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_EditProject.BackgroundImage = global::ProjectHelper.Properties.Resources.AppleScript_Utility_128px_1068149_easyicon_net;
            this.Btn_EditProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_EditProject.Location = new System.Drawing.Point(114, 35);
            this.Btn_EditProject.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_EditProject.Name = "Btn_EditProject";
            this.Btn_EditProject.Size = new System.Drawing.Size(197, 161);
            this.Btn_EditProject.TabIndex = 0;
            this.Btn_EditProject.UseVisualStyleBackColor = true;
            this.Btn_EditProject.Click += new System.EventHandler(this.Btn_EditProject_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImage = global::ProjectHelper.Properties.Resources.database_128px_538649_easyicon_net;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(540, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 161);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_EditProject_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackgroundImage = global::ProjectHelper.Properties.Resources.filing_189_06870229008px_1146929_easyicon_net;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(967, 35);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 161);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_EditProject_Click);
            // 
            // tSMItem_File
            // 
            this.tSMItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMItem_exit});
            this.tSMItem_File.Image = global::ProjectHelper.Properties.Resources.icons8_document_64;
            this.tSMItem_File.Name = "tSMItem_File";
            this.tSMItem_File.Size = new System.Drawing.Size(109, 36);
            this.tSMItem_File.Text = "文件";
            // 
            // tSMItem_exit
            // 
            this.tSMItem_exit.Image = global::ProjectHelper.Properties.Resources.icons8_close_window_96;
            this.tSMItem_exit.Name = "tSMItem_exit";
            this.tSMItem_exit.Size = new System.Drawing.Size(164, 38);
            this.tSMItem_exit.Text = "退出";
            // 
            // tSMItem_EditProject
            // 
            this.tSMItem_EditProject.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMItem_ProjectEdit});
            this.tSMItem_EditProject.Image = global::ProjectHelper.Properties.Resources.icons8_compose_80;
            this.tSMItem_EditProject.Name = "tSMItem_EditProject";
            this.tSMItem_EditProject.Size = new System.Drawing.Size(109, 36);
            this.tSMItem_EditProject.Text = "方案";
            // 
            // tSMItem_ProjectEdit
            // 
            this.tSMItem_ProjectEdit.Image = global::ProjectHelper.Properties.Resources.icons8_group_of_projects_48;
            this.tSMItem_ProjectEdit.Name = "tSMItem_ProjectEdit";
            this.tSMItem_ProjectEdit.Size = new System.Drawing.Size(214, 38);
            this.tSMItem_ProjectEdit.Text = "方案编写";
            // 
            // tSMItem_Risk
            // 
            this.tSMItem_Risk.Image = global::ProjectHelper.Properties.Resources.icons8_white_safety_hat_64;
            this.tSMItem_Risk.Name = "tSMItem_Risk";
            this.tSMItem_Risk.Size = new System.Drawing.Size(159, 36);
            this.tSMItem_Risk.Text = "作业风险";
            // 
            // tSMItem_Data
            // 
            this.tSMItem_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMItem_Data_Risk,
            this.tSMItem_Data_Base,
            this.tSMItem_Data_Members});
            this.tSMItem_Data.Image = global::ProjectHelper.Properties.Resources.icons8_database_administrator_48;
            this.tSMItem_Data.Name = "tSMItem_Data";
            this.tSMItem_Data.Size = new System.Drawing.Size(159, 36);
            this.tSMItem_Data.Text = "数据维护";
            // 
            // tSMItem_Data_Risk
            // 
            this.tSMItem_Data_Risk.Image = global::ProjectHelper.Properties.Resources.icons8_medium_risk_40;
            this.tSMItem_Data_Risk.Name = "tSMItem_Data_Risk";
            this.tSMItem_Data_Risk.Size = new System.Drawing.Size(239, 38);
            this.tSMItem_Data_Risk.Text = "风险数据库";
            // 
            // tSMItem_Data_Base
            // 
            this.tSMItem_Data_Base.Image = global::ProjectHelper.Properties.Resources.icons8_work_100;
            this.tSMItem_Data_Base.Name = "tSMItem_Data_Base";
            this.tSMItem_Data_Base.Size = new System.Drawing.Size(239, 38);
            this.tSMItem_Data_Base.Text = "现场数据";
            // 
            // tSMItem_Data_Members
            // 
            this.tSMItem_Data_Members.Image = global::ProjectHelper.Properties.Resources.icons8_workers_filled_100;
            this.tSMItem_Data_Members.Name = "tSMItem_Data_Members";
            this.tSMItem_Data_Members.Size = new System.Drawing.Size(239, 38);
            this.tSMItem_Data_Members.Text = "人员台账";
            // 
            // tSMItem_Help
            // 
            this.tSMItem_Help.Image = global::ProjectHelper.Properties.Resources.icons8_help_48;
            this.tSMItem_Help.Name = "tSMItem_Help";
            this.tSMItem_Help.Size = new System.Drawing.Size(109, 36);
            this.tSMItem_Help.Text = "帮助";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(993, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据维护";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 42);
            this.label3.TabIndex = 1;
            this.label3.Text = "作业风险库";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Main";
            this.Text = "曲靖局检修方案及风险标准化工具 V1.0";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_File;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_exit;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_EditProject;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_ProjectEdit;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Risk;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Data;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Data_Risk;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Data_Base;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Help;
        private System.Windows.Forms.Button Btn_EditProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tSMItem_Data_Members;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}