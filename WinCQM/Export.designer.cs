namespace WinCQM
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbClass = new WinCQM.ComboBoxClass();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseMark = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCalulate = new System.Windows.Forms.Button();
            this.GridViewMark = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBaseMark);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnCalulate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(453, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组合条件";
            // 
            // cmbClass
            // 
            this.cmbClass.ClassID = null;
            this.cmbClass.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbClass.Location = new System.Drawing.Point(105, 24);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(96, 25);
            this.cmbClass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "导出前请确认机器已经安装office2003";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "计算和导出过程需要一段时间，请耐心等待。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "基准分数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择班级";
            // 
            // txtBaseMark
            // 
            this.txtBaseMark.Location = new System.Drawing.Point(328, 21);
            this.txtBaseMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaseMark.Name = "txtBaseMark";
            this.txtBaseMark.Size = new System.Drawing.Size(76, 26);
            this.txtBaseMark.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(245, 61);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(73, 28);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCalulate
            // 
            this.btnCalulate.Location = new System.Drawing.Point(94, 61);
            this.btnCalulate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalulate.Name = "btnCalulate";
            this.btnCalulate.Size = new System.Drawing.Size(80, 28);
            this.btnCalulate.TabIndex = 1;
            this.btnCalulate.Text = "计算";
            this.btnCalulate.UseVisualStyleBackColor = true;
            this.btnCalulate.Click += new System.EventHandler(this.btnCalulate_Click);
            // 
            // GridViewMark
            // 
            this.GridViewMark.AllowUserToAddRows = false;
            this.GridViewMark.AllowUserToDeleteRows = false;
            this.GridViewMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewMark.Location = new System.Drawing.Point(0, 157);
            this.GridViewMark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridViewMark.Name = "GridViewMark";
            this.GridViewMark.ReadOnly = true;
            this.GridViewMark.RowTemplate.Height = 23;
            this.GridViewMark.Size = new System.Drawing.Size(453, 317);
            this.GridViewMark.TabIndex = 1;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 474);
            this.Controls.Add(this.GridViewMark);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Export";
            this.Text = "统计导出";
            this.Load += new System.EventHandler(this.Export_Load);
            this.Resize += new System.EventHandler(this.Export_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaseMark;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCalulate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewMark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComboBoxClass cmbClass;
    }
}