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
    public partial class AddClass : Form
    {
        public AddClass()
        {
            InitializeComponent();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbLab.Checked)
            {
                 LabClass classinfo = new LabClass()
                {
                    LabClassID = txtClassID.Text,
                    LabClassRoom = txtClassRoom.Text,
                    Date = txtDate.Text,
                    TheoryClassID=cmbTheroyClass.ClassID
                };

                LabClassBLL bclass = new LabClassBLL();
                try
                {
                    if (bclass.AddClass(classinfo))
                        MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(rdbTheroy.Checked)
            {
                TheoryClass classinfo = new TheoryClass()
                {
                    TheoryClassID = txtClassID.Text,
                    TheoryClassRoom = txtClassRoom.Text,
                    Date = txtDate.Text                    
                };
                TheoryClassBLL bclass = new TheoryClassBLL();
                try
                {
                    if (bclass.AddClass(classinfo))
                        MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                LabClass classinfo = new LabClass()
                {
                    LabClassID = txtClassID.Text,
                    LabClassRoom = txtClassRoom.Text,
                    Date = txtDate.Text                    
                };

                LabClassBLL bclass = new LabClassBLL();
                try
                {
                    if (bclass.AddClass(classinfo))
                        MessageBox.Show("添加成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cmbTheroyClass_Load(object sender, EventArgs e)
        {
            cmbTheroyClass.BindClass(ClassType.TheoryClass);
            rdbTheroy.Checked = true;
            cmbTheroyClass.Enabled = false;
        }

        private void rdbLab_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLab.Checked)
            {
                cmbTheroyClass.Enabled = true;
            }
            else
            {
                cmbTheroyClass.Enabled = false;
            }
        }
    }
}