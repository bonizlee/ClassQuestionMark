using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassQuestionMark.BLL;

namespace WinCQM
{
    public partial class MainParent : Form
    {
        private static Quiz FRMQUIZ;
        private static FormQuery FRMQUERY;
        private string CLASSID;
        public MainParent()
        {
            InitializeComponent();
        }

        private Quiz GetQuizForm()
        {
            if (FRMQUIZ == null || FRMQUIZ.IsDisposed)
            {               
                FRMQUIZ = new Quiz(CLASSID);
                FRMQUIZ.MdiParent = this;
            }
            return FRMQUIZ;
        }

        private void mnuAsk_Click(object sender, EventArgs e)
        {
            Quiz frmquiz = GetQuizForm();
            if(!frmquiz.IsDisposed)
                frmquiz.Show();
        }

        private FormQuery GetFormQuery()
        {
            if (FRMQUERY == null || FRMQUERY.IsDisposed)
            {
                FRMQUERY = new FormQuery();
                FRMQUERY.MdiParent = this;
            }
            return FRMQUERY;
        }

        private void mnuQueryMark_Click(object sender, EventArgs e)
        {
            FormQuery frmquery = GetFormQuery();
            frmquery.Show();
        }

        private void mnuSelectClass_Click(object sender, EventArgs e)
        {
            SelectClass frmclass = new SelectClass();
            frmclass.ShowDialog();
            CLASSID = frmclass.ClassID;
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            Export frmexport = new Export();
            frmexport.MdiParent=this;
            frmexport.Show();
        }

        private void mnuFree_Click(object sender, EventArgs e)
        {
            FormRelease frmrelease = new FormRelease();
            frmrelease.MdiParent = this;
            frmrelease.Show();
        }

        private void mnuChangeClass_Click(object sender, EventArgs e)
        {
            ChangeClass frmch = new ChangeClass();
            frmch.MdiParent=this;
            frmch.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutBoniz about = new AboutBoniz();
            about.ShowDialog();
        }

        private void mnuAddClass_Click(object sender, EventArgs e)
        {
            AddClass frmaddclass = new AddClass();
            frmaddclass.MdiParent = this;
            frmaddclass.Show();
        }

        private void mnuAddStudentBatch_Click(object sender, EventArgs e)
        {
            BatchStudent frmbatchstudent = new BatchStudent();
            frmbatchstudent.MdiParent = this;
            frmbatchstudent.Show();
        }

        private void mnuAddStudentOne_Click(object sender, EventArgs e)
        {
            AddStudent frmaddstudent = new AddStudent();
            frmaddstudent.MdiParent = this;
            frmaddstudent.Show();
        }

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            SettingParm frmsettingparm = new SettingParm();
            frmsettingparm.MdiParent = this;
            frmsettingparm.Show();
        }

        private void mnuClearDB_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("真的要清空数据库吗，所以数据将会擦除。", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                Setting.ClearDataBase();
        }

       
    }
}