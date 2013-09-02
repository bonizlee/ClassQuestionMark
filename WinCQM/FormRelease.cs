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
    public partial class FormRelease : Form
    {
        private IList<StudentInfo> students = new List<StudentInfo>();
        public FormRelease()
        {
            InitializeComponent();
        }

        private void FormRelease_Load(object sender, EventArgs e)
        {
            BindData();
        }

        protected void BindData()
        {
            StudentBLL bstudent = new StudentBLL();
            students= bstudent.GetReleaseStudent();
            if (students == null)
            {
                MessageBox.Show("没有学生");
                return;
            }
            GridViewMark.AutoGenerateColumns = false;
            GridViewMark.Columns.Clear();
            GridViewMark.DataSource = students;

            DataGridViewTextBoxColumn txtID = new DataGridViewTextBoxColumn();
            txtID.CellTemplate = new DataGridViewTextBoxCell();
            GridViewMark.Columns.Insert(0, txtID);
            txtID.HeaderText = "学号";
            txtID.DataPropertyName = "SID";            

            DataGridViewTextBoxColumn txtName = new DataGridViewTextBoxColumn();
            txtName.CellTemplate = new DataGridViewTextBoxCell();
            GridViewMark.Columns.Insert(1, txtName);
            txtName.HeaderText = "学号";
            txtName.DataPropertyName = "SName";

            DataGridViewTextBoxColumn txtClass = new DataGridViewTextBoxColumn();
            txtClass.CellTemplate = new DataGridViewTextBoxCell();
            GridViewMark.Columns.Insert(2, txtClass);
            txtClass.HeaderText = "班别";
            txtClass.DataPropertyName = "ClassID";
            txtClass.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            DataGridViewButtonColumn delcol = new DataGridViewButtonColumn();
            delcol.CellTemplate = new DataGridViewButtonCell();
            GridViewMark.Columns.Insert(3, delcol);
            delcol.HeaderText = "删除";
            delcol.UseColumnTextForButtonValue = true;
            delcol.Text = "删除";
            delcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StudentBLL bStudent = new StudentBLL();
            if (bStudent.ChangeRate(txtSID.Text, int.Parse(Setting.FreeRate))) 
            {
                MessageBox.Show("登记成功！");
                BindData();
            }
            else
            {
                MessageBox.Show("没有此学生！");
            }
        }

        private void GridViewMark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;
            //删除操作
            if (CIndex == 3)
            {
                StudentBLL bStudent = new StudentBLL();
                //十分奇怪的问题，按钮列的序号变成0，学号列的序号为1
                if (bStudent.ChangeRate(GridViewMark.Rows[e.RowIndex].Cells[0].Value.ToString(),0))
                {
                    MessageBox.Show("删除成功");
                    BindData();
                }
                else
                    MessageBox.Show("删除失败");
            }
        }

        private void FormRelease_Resize(object sender, EventArgs e)
        {
            GridViewMark.Height = this.Height - groupBox1.Height-50;            
        }
    }
}