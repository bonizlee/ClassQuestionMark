namespace WinCQM
{
    partial class FormRelease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelease));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.GridViewMark = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(473, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加免提问学生";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(301, 34);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 32);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(82, 35);
            this.txtSID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(164, 29);
            this.txtSID.TabIndex = 0;
            // 
            // GridViewMark
            // 
            this.GridViewMark.AllowUserToAddRows = false;
            this.GridViewMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewMark.Location = new System.Drawing.Point(0, 112);
            this.GridViewMark.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GridViewMark.Name = "GridViewMark";
            this.GridViewMark.ReadOnly = true;
            this.GridViewMark.RowTemplate.Height = 23;
            this.GridViewMark.Size = new System.Drawing.Size(473, 321);
            this.GridViewMark.TabIndex = 1;
            this.GridViewMark.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMark_CellContentClick);
            // 
            // FormRelease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 433);
            this.Controls.Add(this.GridViewMark);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormRelease";
            this.Text = "免提问登记";
            this.Load += new System.EventHandler(this.FormRelease_Load);
            this.Resize += new System.EventHandler(this.FormRelease_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.DataGridView GridViewMark;
    }
}