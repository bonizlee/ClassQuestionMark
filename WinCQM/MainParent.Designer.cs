namespace WinCQM
{
    partial class MainParent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainParent));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuQuiz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAsk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFree = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStudentBatch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddStudentOne = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueryMark = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuiz,
            this.mnuEdit,
            this.mnuQuery,
            this.mnuAbout});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(515, 27);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mnuQuiz
            // 
            this.mnuQuiz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSelectClass,
            this.mnuAsk});
            this.mnuQuiz.Name = "mnuQuiz";
            this.mnuQuiz.Size = new System.Drawing.Size(92, 23);
            this.mnuQuiz.Text = "课堂提问(&Q)";
            // 
            // mnuSelectClass
            // 
            this.mnuSelectClass.Name = "mnuSelectClass";
            this.mnuSelectClass.Size = new System.Drawing.Size(152, 24);
            this.mnuSelectClass.Text = "选择班级(&S)";
            this.mnuSelectClass.Click += new System.EventHandler(this.mnuSelectClass_Click);
            // 
            // mnuAsk
            // 
            this.mnuAsk.Name = "mnuAsk";
            this.mnuAsk.Size = new System.Drawing.Size(152, 24);
            this.mnuAsk.Text = "提问登记(&Q)";
            this.mnuAsk.Click += new System.EventHandler(this.mnuAsk_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFree,
            this.mnuChangeClass,
            this.mnuAddClass,
            this.mnuAddStudent,
            this.mnuSetting});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(94, 23);
            this.mnuEdit.Text = "修改编辑(&M)";
            // 
            // mnuFree
            // 
            this.mnuFree.Name = "mnuFree";
            this.mnuFree.Size = new System.Drawing.Size(158, 24);
            this.mnuFree.Text = "免提问登记(&F)";
            this.mnuFree.Click += new System.EventHandler(this.mnuFree_Click);
            // 
            // mnuChangeClass
            // 
            this.mnuChangeClass.Name = "mnuChangeClass";
            this.mnuChangeClass.Size = new System.Drawing.Size(158, 24);
            this.mnuChangeClass.Text = "调班操作(&A)";
            this.mnuChangeClass.Click += new System.EventHandler(this.mnuChangeClass_Click);
            // 
            // mnuAddClass
            // 
            this.mnuAddClass.Name = "mnuAddClass";
            this.mnuAddClass.Size = new System.Drawing.Size(158, 24);
            this.mnuAddClass.Text = "添加班级(&C)";
            this.mnuAddClass.Click += new System.EventHandler(this.mnuAddClass_Click);
            // 
            // mnuAddStudent
            // 
            this.mnuAddStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddStudentBatch,
            this.mnuAddStudentOne});
            this.mnuAddStudent.Name = "mnuAddStudent";
            this.mnuAddStudent.Size = new System.Drawing.Size(158, 24);
            this.mnuAddStudent.Text = "添加学生(&S)";
            // 
            // mnuAddStudentBatch
            // 
            this.mnuAddStudentBatch.Name = "mnuAddStudentBatch";
            this.mnuAddStudentBatch.Size = new System.Drawing.Size(152, 24);
            this.mnuAddStudentBatch.Text = "批量添加";
            this.mnuAddStudentBatch.Click += new System.EventHandler(this.mnuAddStudentBatch_Click);
            // 
            // mnuAddStudentOne
            // 
            this.mnuAddStudentOne.Name = "mnuAddStudentOne";
            this.mnuAddStudentOne.Size = new System.Drawing.Size(152, 24);
            this.mnuAddStudentOne.Text = "逐一添加";
            this.mnuAddStudentOne.Click += new System.EventHandler(this.mnuAddStudentOne_Click);
            // 
            // mnuQuery
            // 
            this.mnuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQueryMark,
            this.mnuExport});
            this.mnuQuery.Name = "mnuQuery";
            this.mnuQuery.Size = new System.Drawing.Size(65, 23);
            this.mnuQuery.Text = "查询(&U)";
            // 
            // mnuQueryMark
            // 
            this.mnuQueryMark.Name = "mnuQueryMark";
            this.mnuQueryMark.Size = new System.Drawing.Size(152, 24);
            this.mnuQueryMark.Text = "成绩查询(&M)";
            this.mnuQueryMark.Click += new System.EventHandler(this.mnuQueryMark_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(152, 24);
            this.mnuExport.Text = "导出成绩(&E)";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(64, 23);
            this.mnuAbout.Text = "关于(&A)";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuSetting
            // 
            this.mnuSetting.Name = "mnuSetting";
            this.mnuSetting.Size = new System.Drawing.Size(158, 24);
            this.mnuSetting.Text = "设置参数(&P)";
            this.mnuSetting.Click += new System.EventHandler(this.mnuSetting_Click);
            // 
            // MainParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 445);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainParent";
            this.Text = "课堂提问单机版";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuQuiz;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectClass;
        private System.Windows.Forms.ToolStripMenuItem mnuAsk;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuFree;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeClass;
        private System.Windows.Forms.ToolStripMenuItem mnuQuery;
        private System.Windows.Forms.ToolStripMenuItem mnuQueryMark;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuAddClass;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStudentBatch;
        private System.Windows.Forms.ToolStripMenuItem mnuAddStudentOne;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
    }
}

