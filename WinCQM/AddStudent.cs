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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            cmbClass.BindClass(ClassType.LabClass);
        }       

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtSID.Text = string.Empty;
            txtSName.Text = string.Empty;            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtSID.Text == string.Empty || txtSName.Text == string.Empty)
            {
                MessageBox.Show("请填写完整所有信息");
                return;
            }

            StudentBLL bllstu = new StudentBLL();
            if (bllstu.GetStudentBySID(txtSID.Text) != null)
            {
                MessageBox.Show("已经存在该学生");
                return;
            }
            int Rate=0;
           
            try
            {
                StudentInfo student = new StudentInfo()
                {
                    SID = txtSID.Text,
                    SName = txtSName.Text,
                    LabClassID = cmbClass.ClassID,
                    Rate = Rate
                };
                if (bllstu.AddStudent(student))
                {
                    MessageBox.Show("添加成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}