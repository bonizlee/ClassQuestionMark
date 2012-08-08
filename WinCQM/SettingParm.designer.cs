namespace WinCQM
{
    partial class SettingParm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFreeRate = new System.Windows.Forms.TextBox();
            this.txtInitRate = new System.Windows.Forms.TextBox();
            this.txtBaseMark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstGrade = new System.Windows.Forms.ListBox();
            this.btnRemoveGrade = new System.Windows.Forms.Button();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.txtNewGrade = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "基础成绩（默认70）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "免提问值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "机率（数值越大，机率越小，达到免提问值不抽签）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "初始值";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFreeRate);
            this.panel1.Controls.Add(this.txtInitRate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 99);
            this.panel1.TabIndex = 3;
            // 
            // txtFreeRate
            // 
            this.txtFreeRate.Location = new System.Drawing.Point(255, 53);
            this.txtFreeRate.Name = "txtFreeRate";
            this.txtFreeRate.Size = new System.Drawing.Size(100, 29);
            this.txtFreeRate.TabIndex = 3;
            // 
            // txtInitRate
            // 
            this.txtInitRate.Location = new System.Drawing.Point(66, 53);
            this.txtInitRate.Name = "txtInitRate";
            this.txtInitRate.Size = new System.Drawing.Size(86, 29);
            this.txtInitRate.TabIndex = 0;
            // 
            // txtBaseMark
            // 
            this.txtBaseMark.Location = new System.Drawing.Point(179, 114);
            this.txtBaseMark.Name = "txtBaseMark";
            this.txtBaseMark.Size = new System.Drawing.Size(100, 29);
            this.txtBaseMark.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstGrade);
            this.groupBox1.Controls.Add(this.btnRemoveGrade);
            this.groupBox1.Controls.Add(this.btnAddGrade);
            this.groupBox1.Controls.Add(this.txtNewGrade);
            this.groupBox1.Location = new System.Drawing.Point(0, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "评分等级";
            // 
            // lstGrade
            // 
            this.lstGrade.FormattingEnabled = true;
            this.lstGrade.ItemHeight = 21;
            this.lstGrade.Location = new System.Drawing.Point(236, 28);
            this.lstGrade.Name = "lstGrade";
            this.lstGrade.Size = new System.Drawing.Size(119, 88);
            this.lstGrade.TabIndex = 1;
            // 
            // btnRemoveGrade
            // 
            this.btnRemoveGrade.Location = new System.Drawing.Point(147, 63);
            this.btnRemoveGrade.Name = "btnRemoveGrade";
            this.btnRemoveGrade.Size = new System.Drawing.Size(36, 30);
            this.btnRemoveGrade.TabIndex = 3;
            this.btnRemoveGrade.Text = "<";
            this.btnRemoveGrade.UseVisualStyleBackColor = true;
            this.btnRemoveGrade.Click += new System.EventHandler(this.btnRemoveGrade_Click);
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(147, 27);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(36, 30);
            this.btnAddGrade.TabIndex = 2;
            this.btnAddGrade.Text = ">";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // txtNewGrade
            // 
            this.txtNewGrade.Location = new System.Drawing.Point(23, 29);
            this.txtNewGrade.Name = "txtNewGrade";
            this.txtNewGrade.Size = new System.Drawing.Size(71, 29);
            this.txtNewGrade.TabIndex = 0;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(68, 281);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 31);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(218, 281);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 31);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SettingParm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 324);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBaseMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SettingParm";
            this.Text = "设置参数";
            this.Load += new System.EventHandler(this.SettingParm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFreeRate;
        private System.Windows.Forms.TextBox txtInitRate;
        private System.Windows.Forms.TextBox txtBaseMark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.TextBox txtNewGrade;
        private System.Windows.Forms.ListBox lstGrade;
        private System.Windows.Forms.Button btnRemoveGrade;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnReturn;
    }
}