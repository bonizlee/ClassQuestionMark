using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using ClassQuestionMark.BLL;
using ClassQuestionMark.Model;


namespace WinCQM
{
    public partial class Mark : Form
    {
        private string SID;
        ClassQuestionMark.BLL.StudentBLL bStudent = new StudentBLL();
        StudentInfo stuinfo;

        public Mark(string pSID)
        {
            InitializeComponent();
            SID = pSID;
            lblSID.Text = SID;                     
            stuinfo = bStudent.GetStudentBySID(pSID);
            if (stuinfo == null || stuinfo.SID == null)
            {                
                MessageBox.Show("没有这个学生！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                this.Dispose();
                return;
            }
            cmbMark.DataSource = ClassQuestionMark.BLL.Setting.Grades;
            cmbMark.SelectedIndex = 1;
            lblSName.Text = stuinfo.SName;            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ClassQuestionMark.BLL.MarkBLL bMark = new ClassQuestionMark.BLL.MarkBLL();
           
            if (bMark.AddMark(stuinfo.SID, Convert.ToInt32(cmbMark.Text)))
            {
                StudentBLL bStudent = new StudentBLL();
                bStudent.ChangeRate(stuinfo.SID, (int)(stuinfo.Rate + Convert.ToInt16(cmbMark.Text)));
                MessageBox.Show(stuinfo.SName + "得分是:" + cmbMark.Text,"登记",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                
                MessageBox.Show("添加成绩失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}