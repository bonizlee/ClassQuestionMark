using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ClassQuestionMark.BLL;

namespace WinCQM
{
    public enum ClassType
    {
        LabClass,
        TheoryClass
    };

    public partial class ComboBoxClass : UserControl
    {
        public ComboBoxClass()
        {
            InitializeComponent();            
        }

        public void BindClass(ClassType ct)
        {
            switch (ct)
            {
                case ClassType.LabClass:
                    LabClassBLL lcb = new LabClassBLL();
                    cmbClass.DataSource = null;
                    cmbClass.DataSource = lcb.GetAllLabClass();
                    cmbClass.DisplayMember = "LabClassID";
                    cmbClass.ValueMember = "LabClassID";
                    break;
                case ClassType.TheoryClass:
                    TheoryClassBLL tcb = new TheoryClassBLL();
                    cmbClass.DataSource = null;
                    cmbClass.DataSource = tcb.GetAllTheoryClass();
                    cmbClass.DisplayMember = "TheoryClassID";
                    cmbClass.ValueMember = "TheoryClassID";
                    break;               
            }   
        }

        public string ClassID
        {
            get
            {
                if (cmbClass.SelectedValue != null)
                    return cmbClass.SelectedValue.ToString();
                else
                    return null;
            }
            set
            {
                cmbClass.SelectedItem = value;
            }
        }  
	
    }
}
