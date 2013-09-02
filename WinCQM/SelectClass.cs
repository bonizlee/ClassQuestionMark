using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassQuestionMark.BLL;
using ClassQuestionMark.Model;

namespace WinCQM
{
    public partial class SelectClass : Form
    {
        public string ClassID;
        public SelectClass()
        {
            InitializeComponent();
            cmbLabClass.BindClass(ClassType.LabClass);
            cmbTheoryClass.BindClass(ClassType.TheoryClass);
            cmbLabClass.Visible = false;
            cmbTheoryClass.Visible = true;
        }     

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbLab.Checked)
                ClassID = cmbLabClass.ClassID;
            else
                ClassID = cmbTheoryClass.ClassID;
            this.Close();
        }

        private void rdbClass_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLab.Checked)
            {
                cmbLabClass.Visible = true;
                cmbTheoryClass.Visible = false;
            }
            else
            {
                cmbLabClass.Visible = false;
                cmbTheoryClass.Visible = true;
            }
        }
    }
}