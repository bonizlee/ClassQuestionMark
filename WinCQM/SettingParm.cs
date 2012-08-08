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
    public partial class SettingParm : Form
    {
        protected IList<string> arrayGrade = new List<string>();
        public SettingParm()
        {
            InitializeComponent();
        }

        protected void BindList()
        {
            lstGrade.DataSource = null;
            lstGrade.DataSource = arrayGrade;
        }

        private void SettingParm_Load(object sender, EventArgs e)
        {
            txtBaseMark.Text = Setting.BaseMark;
            txtFreeRate.Text = Setting.FreeRate;
            txtInitRate.Text = Setting.InitRate;
            arrayGrade = Setting.Grades;
            BindList();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            int newgrade;
            if (CheckString.IsNumber(txtNewGrade.Text,out newgrade))
            {
                int selectindex = lstGrade.SelectedIndex;
                arrayGrade.Insert(selectindex, newgrade.ToString());
                BindList();               
            }
            else
                MessageBox.Show("请输入有效整数");
        }

        private void btnRemoveGrade_Click(object sender, EventArgs e)
        {
            arrayGrade.RemoveAt(lstGrade.SelectedIndex);
            BindList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckString.IsNumber(txtInitRate.Text)&&CheckString.IsNumber(txtBaseMark.Text)&&CheckString.IsNumber(txtFreeRate.Text))
            {
                try
                {
                    Setting.InitRate = txtInitRate.Text;
                    Setting.BaseMark = txtBaseMark.Text;
                    Setting.FreeRate = txtFreeRate.Text;
                    Setting.Grades = arrayGrade;
                    MessageBox.Show("修改成功");
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("写入错误:"+ex.Message);   
                }   
            }
        }
    }
}