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
    public partial class Quiz : Form
    {
        private static string CLASSID;
        private static List<string> RandSID = new List<string>();
        private static int StudentIndex;
       

        public Quiz(string pClassID)
        {
            if (string.IsNullOrEmpty(pClassID))
            {               
                MessageBox.Show("请先选择上课的班级！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            InitializeComponent();
            CLASSID = pClassID;
            this.Text = pClassID + "班提问";
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            SelectorBLL SelectStudent = new SelectorBLL();
            RandSID = (List<string>)SelectStudent.GetRandomList(CLASSID);
            StudentIndex = 0;
            MessageBox.Show("随机排序完成！","信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            if (StudentIndex < RandSID.Count)
            {  
                Mark frmMark = new Mark(RandSID[StudentIndex]);
                frmMark.ShowDialog();
                StudentIndex++;
            }
            else
            {
                MessageBox.Show("没有学生！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSID.Text))
            {
               PopupMark(txtSID.Text);
            }
            else
            {
                StudentBLL bstudent = new StudentBLL();
                StudentInfo stuinfo = bstudent.GetStudentByName(txtName.Text);
                if (stuinfo != null && stuinfo.SID!=null)
                    PopupMark(stuinfo.SID);
                else
                    MessageBox.Show("没有这个学生！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void PopupMark(string pSID)
        {
            Mark frmMark = new Mark(pSID);
            if (!frmMark.IsDisposed)
                frmMark.ShowDialog();
        }
    }
}