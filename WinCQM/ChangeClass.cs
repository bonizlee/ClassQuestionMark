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
    public partial class ChangeClass : Form
    {
        static StudentInfo stuinfo = null;
        public ChangeClass()
        {
            InitializeComponent();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            ClassQuestionMark.BLL.StudentBLL bstudent = new StudentBLL();
            if (stuinfo != null)
            {
                stuinfo.LabClassID = cmbClass.ClassID;
                if (bstudent.UpdateStudent(stuinfo))
                {
                    MessageBox.Show(stuinfo.SName + "��ת��" + stuinfo.LabClassID + "�࣡");
                    return;
                }
            }
           MessageBox.Show("ת��ʧ�ܣ�");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StudentBLL bstudent = new StudentBLL();
            LabClassBLL cls = new LabClassBLL();
            stuinfo = bstudent.GetStudentBySID(txtSID.Text);
            if (stuinfo == null)
            {
                MessageBox.Show("û�����ѧ��");
                return;
            }
            lblSName.Text = stuinfo.SName;
            cmbClass.BindClass(ClassType.LabClass);
            cmbClass.ClassID = stuinfo.LabClassID;
        }   
    }
}