namespace WinCQM
{
    partial class AddClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.txtClassRoom = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbLab = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbTheroy = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTheroyClass = new WinCQM.ComboBoxClass();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "班号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "上课时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "课室";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 153);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtClassID
            // 
            this.txtClassID.Location = new System.Drawing.Point(95, 26);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(143, 29);
            this.txtClassID.TabIndex = 4;
            // 
            // txtClassRoom
            // 
            this.txtClassRoom.Location = new System.Drawing.Point(95, 116);
            this.txtClassRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassRoom.Name = "txtClassRoom";
            this.txtClassRoom.Size = new System.Drawing.Size(143, 29);
            this.txtClassRoom.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(95, 71);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(143, 29);
            this.txtDate.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbLab);
            this.panel1.Controls.Add(this.rdbSingle);
            this.panel1.Controls.Add(this.rdbTheroy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTheroyClass);
            this.panel1.Location = new System.Drawing.Point(260, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 175);
            this.panel1.TabIndex = 7;
            // 
            // rdbLab
            // 
            this.rdbLab.AutoSize = true;
            this.rdbLab.Location = new System.Drawing.Point(21, 71);
            this.rdbLab.Name = "rdbLab";
            this.rdbLab.Size = new System.Drawing.Size(76, 25);
            this.rdbLab.TabIndex = 3;
            this.rdbLab.TabStop = true;
            this.rdbLab.Text = "实验课";
            this.rdbLab.UseVisualStyleBackColor = true;
            this.rdbLab.CheckedChanged += new System.EventHandler(this.rdbLab_CheckedChanged);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(21, 40);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(108, 25);
            this.rdbSingle.TabIndex = 3;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "不分大小课";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbTheroy
            // 
            this.rdbTheroy.AutoSize = true;
            this.rdbTheroy.Location = new System.Drawing.Point(21, 9);
            this.rdbTheroy.Name = "rdbTheroy";
            this.rdbTheroy.Size = new System.Drawing.Size(76, 25);
            this.rdbTheroy.TabIndex = 3;
            this.rdbTheroy.TabStop = true;
            this.rdbTheroy.Text = "理论课";
            this.rdbTheroy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "选择关联的理论课";
            // 
            // cmbTheroyClass
            // 
            this.cmbTheroyClass.ClassID = null;
            this.cmbTheroyClass.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbTheroyClass.Location = new System.Drawing.Point(15, 129);
            this.cmbTheroyClass.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTheroyClass.Name = "cmbTheroyClass";
            this.cmbTheroyClass.Size = new System.Drawing.Size(146, 32);
            this.cmbTheroyClass.TabIndex = 0;
            this.cmbTheroyClass.Load += new System.EventHandler(this.cmbTheroyClass_Load);
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtClassRoom);
            this.Controls.Add(this.txtClassID);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddClass";
            this.Text = "添加班级";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtClassRoom;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Panel panel1;
        private ComboBoxClass cmbTheroyClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbLab;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbTheroy;
    }
}