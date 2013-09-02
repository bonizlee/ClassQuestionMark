namespace WinCQM
{
    partial class BatchStudent
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.GridViewStudent = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel文件|*.xls";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(392, 21);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "浏览(&B)…";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(114, 21);
            this.txtFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(241, 29);
            this.txtFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件路径：";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(274, 58);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "添加记录(&A)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // GridViewStudent
            // 
            this.GridViewStudent.AllowUserToAddRows = false;
            this.GridViewStudent.AllowUserToDeleteRows = false;
            this.GridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewStudent.Location = new System.Drawing.Point(0, 153);
            this.GridViewStudent.Margin = new System.Windows.Forms.Padding(4);
            this.GridViewStudent.Name = "GridViewStudent";
            this.GridViewStudent.RowTemplate.Height = 23;
            this.GridViewStudent.Size = new System.Drawing.Size(521, 315);
            this.GridViewStudent.TabIndex = 4;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(66, 58);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(116, 34);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入Excel(&E)";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // BatchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 468);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.GridViewStudent);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BatchStudent";
            this.Text = "批量添加学生";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView GridViewStudent;
        private System.Windows.Forms.Button btnImport;
    }
}