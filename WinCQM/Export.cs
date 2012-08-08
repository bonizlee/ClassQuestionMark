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
    public partial class Export : Form
    {
        private IList<StudentInfo> Marks = null;
        public Export()
        {
            InitializeComponent();
        }

        private void Export_Load(object sender, EventArgs e)
        {
            LabClassBLL bclass = new LabClassBLL();
            cmbClass.BindClass(ClassType.LabClass);
            txtBaseMark.Text = Setting.BaseMark;
            txtBaseMark.ReadOnly = true;
        }       

        private void btnCalulate_Click(object sender, EventArgs e)
        {           
            int basemark = Convert.ToInt16(txtBaseMark.Text);
            MarkBLL FMark = new MarkBLL();
            Marks = FMark.FinalMark(cmbClass.ClassID, basemark);
            MarkBind();
        }

        protected void MarkBind()
        {
            if (Marks == null)
                return;
            GridViewMark.Columns.Clear();
            GridViewMark.DataSource = Marks;            

            GridViewMark.Columns[0].Visible = true;
            GridViewMark.Columns[0].HeaderText = "学号";
            GridViewMark.Columns[0].DataPropertyName = "SID";

            GridViewMark.Columns[1].Visible = true;
            GridViewMark.Columns[1].HeaderText = "姓名";
            GridViewMark.Columns[1].DataPropertyName = "SName";

            GridViewMark.Columns[2].Visible = true;
            GridViewMark.Columns[2].HeaderText = "成绩";
            GridViewMark.Columns[2].DataPropertyName = "Rate";
            GridViewMark.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            GridViewMark.Columns[3].Visible = true;
            GridViewMark.Columns[3].HeaderText = "班别";
            GridViewMark.Columns[3].DataPropertyName = "LabClassID";

            GridViewMark.Columns[4].Visible = false;
            GridViewMark.Columns[5].Visible = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Marks != null)
            {
                ExportExcel ee = new ExportExcel();
                ee.ExportToExcel(cmbClass.ClassID+"班课堂提问成绩", DateTime.Now.ToShortDateString(), GridViewMark);
            }
            else
            {
                MessageBox.Show("没有数据，不能导出");
                return;
            }
        }

        private void Export_Resize(object sender, EventArgs e)
        {
            GridViewMark.Height = this.Height - groupBox1.Height - 50;
        }

    }
}