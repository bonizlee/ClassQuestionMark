namespace WinCQM
{
    partial class SelectClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectClass));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.rdbLab = new System.Windows.Forms.RadioButton();
            this.rdbTheroy = new System.Windows.Forms.RadioButton();
            this.cmbLabClass = new WinCQM.ComboBoxClass();
            this.cmbTheoryClass = new WinCQM.ComboBoxClass();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择上课的班";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.Location = new System.Drawing.Point(89, 156);
            this.btnOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 35);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rdbLab
            // 
            this.rdbLab.AutoSize = true;
            this.rdbLab.Location = new System.Drawing.Point(36, 57);
            this.rdbLab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbLab.Name = "rdbLab";
            this.rdbLab.Size = new System.Drawing.Size(87, 29);
            this.rdbLab.TabIndex = 3;
            this.rdbLab.Text = "实验课";
            this.rdbLab.UseVisualStyleBackColor = true;
            this.rdbLab.CheckedChanged += new System.EventHandler(this.rdbClass_CheckedChanged);
            // 
            // rdbTheroy
            // 
            this.rdbTheroy.AutoSize = true;
            this.rdbTheroy.Checked = true;
            this.rdbTheroy.Location = new System.Drawing.Point(164, 57);
            this.rdbTheroy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTheroy.Name = "rdbTheroy";
            this.rdbTheroy.Size = new System.Drawing.Size(87, 29);
            this.rdbTheroy.TabIndex = 3;
            this.rdbTheroy.TabStop = true;
            this.rdbTheroy.Text = "理论课";
            this.rdbTheroy.UseVisualStyleBackColor = true;
            this.rdbTheroy.CheckedChanged += new System.EventHandler(this.rdbClass_CheckedChanged);
            // 
            // cmbLabClass
            // 
            this.cmbLabClass.ClassID = null;
            this.cmbLabClass.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.cmbLabClass.Location = new System.Drawing.Point(74, 106);
            this.cmbLabClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLabClass.Name = "cmbLabClass";
            this.cmbLabClass.Size = new System.Drawing.Size(146, 30);
            this.cmbLabClass.TabIndex = 4;
            // 
            // cmbTheoryClass
            // 
            this.cmbTheoryClass.ClassID = null;
            this.cmbTheoryClass.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.cmbTheoryClass.Location = new System.Drawing.Point(74, 106);
            this.cmbTheoryClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTheoryClass.Name = "cmbTheoryClass";
            this.cmbTheoryClass.Size = new System.Drawing.Size(146, 30);
            this.cmbTheoryClass.TabIndex = 5;
            // 
            // SelectClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 209);
            this.Controls.Add(this.rdbTheroy);
            this.Controls.Add(this.rdbLab);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLabClass);
            this.Controls.Add(this.cmbTheoryClass);
            this.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "SelectClass";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "选择班级";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private ComboBoxClass cmbLabClass;
        private ComboBoxClass cmbTheoryClass;
        private System.Windows.Forms.RadioButton rdbLab;
        private System.Windows.Forms.RadioButton rdbTheroy;
        
    }
}