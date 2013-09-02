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
    public partial class BatchStudent : Form
    {
        DataSet dsStudent = new DataSet();
        public BatchStudent()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ExportExcel ee = new ExportExcel();
            if (!string.IsNullOrEmpty(txtFile.Text))
            {                
               dsStudent = ee.ExcelToDS(txtFile.Text);
               StudentBind();
            }
        }

        void StudentBind()
        {
            GridViewStudent.Columns.Clear();           
            GridViewStudent.DataSource = dsStudent.Tables[0];
 
            GridViewStudent.Columns[0].HeaderText = "学号";      
            GridViewStudent.Columns[1].HeaderText = "姓名";          
            GridViewStudent.Columns[2].HeaderText = "班级";         
            GridViewStudent.Columns[3].HeaderText = "机率";        
                 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StudentBLL bstudent = new StudentBLL();
            if(dsStudent==new DataSet())
                MessageBox.Show("没有数据");
            try
            {
                if (bstudent.BatchAdd(dsStudent))
                    MessageBox.Show("添加成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}