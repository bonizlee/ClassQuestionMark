namespace WinCQM
{
    partial class ChangeClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeClass));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.cmbClass = new WinCQM.ComboBoxClass();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntOK);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(423, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(172, 147);
            this.bntOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(70, 31);
            this.bntOK.TabIndex = 7;
            this.bntOK.Text = "确定";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // cmbClass
            // 
            this.cmbClass.ClassID = null;
            this.cmbClass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cmbClass.Location = new System.Drawing.Point(283, 93);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(115, 35);
            this.cmbClass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "班别：";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(107, 89);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(0, 21);
            this.lblSName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(273, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(110, 33);
            this.txtSID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(116, 29);
            this.txtSID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // ChangeClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 204);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeClass";
            this.Text = "调班操作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label label2;
        private ComboBoxClass cmbClass;
    }
}