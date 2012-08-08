namespace WinCQM
{
    partial class FormQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuery));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtToDate = new System.Windows.Forms.TextBox();
            this.TxtFromDate = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.GridViewMark = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtToDate);
            this.groupBox1.Controls.Add(this.TxtFromDate);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(517, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "注：时间格式为“年－月－日”";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(305, 72);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(101, 37);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询(&Q)";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "到";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "时间从";
            // 
            // TxtToDate
            // 
            this.TxtToDate.Location = new System.Drawing.Point(305, 23);
            this.TxtToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtToDate.Name = "TxtToDate";
            this.TxtToDate.Size = new System.Drawing.Size(151, 29);
            this.TxtToDate.TabIndex = 2;
            // 
            // TxtFromDate
            // 
            this.TxtFromDate.Location = new System.Drawing.Point(101, 23);
            this.TxtFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtFromDate.Name = "TxtFromDate";
            this.TxtFromDate.Size = new System.Drawing.Size(133, 29);
            this.TxtFromDate.TabIndex = 1;
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(101, 72);
            this.txtSID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(133, 29);
            this.txtSID.TabIndex = 0;
            // 
            // GridViewMark
            // 
            this.GridViewMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridViewMark.Location = new System.Drawing.Point(0, 161);
            this.GridViewMark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridViewMark.Name = "GridViewMark";
            this.GridViewMark.RowTemplate.Height = 23;
            this.GridViewMark.Size = new System.Drawing.Size(517, 333);
            this.GridViewMark.TabIndex = 1;
            this.GridViewMark.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewMark_CellContentClick);
            // 
            // FormQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 494);
            this.Controls.Add(this.GridViewMark);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQuery";
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.FormQuery_Load);
            this.Resize += new System.EventHandler(this.FormQuery_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox TxtToDate;
        private System.Windows.Forms.TextBox TxtFromDate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewMark;
        private System.Windows.Forms.Label label4;
    }
}