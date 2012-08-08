using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassQuestionMark.BLL;
using ClassQuestionMark.Model;
using System.Text.RegularExpressions;//���ʽ����

namespace WinCQM
{
    public partial class FormQuery : Form
    {
        private IList<MarkInfo> Marks=null;
        int MAXMARK = Setting.MaxGrade;
        int MINMARK = Setting.MinGrade;
        public FormQuery()
        {
            InitializeComponent();
        }

        protected void MarkBind()
        {
            if (Marks == null)
                return;
            GridViewMark.Columns.Clear();
            GridViewMark.DataSource = Marks;            

            GridViewMark.Columns[0].Visible = false;
            GridViewMark.Columns[0].HeaderText = "ID";
            GridViewMark.Columns[0].DataPropertyName = "MarkID";

            GridViewMark.Columns[1].Visible = true;
            GridViewMark.Columns[1].HeaderText = "ѧ��";
            GridViewMark.Columns[1].DataPropertyName = "SID";

            GridViewMark.Columns[2].Visible = true;
            GridViewMark.Columns[2].HeaderText = "�ɼ�";
            GridViewMark.Columns[2].DataPropertyName = "Mark";
            GridViewMark.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            GridViewMark.Columns[3].Visible = true;
            GridViewMark.Columns[3].HeaderText = "ʱ��";
            GridViewMark.Columns[3].DataPropertyName = "Date";

            DataGridViewButtonColumn delcol = new DataGridViewButtonColumn();
            delcol.CellTemplate = new DataGridViewButtonCell();
            GridViewMark.Columns.Insert(4, delcol);
            delcol.HeaderText = "ɾ��";
            delcol.UseColumnTextForButtonValue = true;
            delcol.Text = "ɾ��";
            delcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.CellTemplate = new DataGridViewButtonCell();
            GridViewMark.Columns.Insert(5, editcol);
            editcol.HeaderText = "�༭";
            editcol.UseColumnTextForButtonValue = true;
            editcol.Text = "�޸�";
            editcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            GridViewMark.Columns[6].Visible = false;
        }

        private void QueryMark()
        {
            MarkBLL bMark = new MarkBLL();
            DateTime[] QDate = new DateTime[]
            {
                new DateTime(),
                new DateTime()
            };
            if (!string.IsNullOrEmpty(txtSID.Text) && !string.IsNullOrEmpty(TxtFromDate.Text) && !string.IsNullOrEmpty(TxtToDate.Text))
            {
                QDate[0] = Convert.ToDateTime(TxtFromDate.Text);
                QDate[1] = Convert.ToDateTime(TxtToDate.Text);
                Marks = bMark.SelectMark(txtSID.Text, QDate);
                MarkBind();
                return;
            }

            if (!string.IsNullOrEmpty(txtSID.Text))
            {
                if (!string.IsNullOrEmpty(TxtToDate.Text))
                {
                    QDate[1] = Convert.ToDateTime(TxtToDate.Text);
                    Marks = bMark.SelectMark(txtSID.Text, QDate);
                    MarkBind();
                    return;
                }
                if (!string.IsNullOrEmpty(TxtFromDate.Text))
                {
                    QDate[0] = Convert.ToDateTime(TxtFromDate.Text);
                    Marks = bMark.SelectMark(txtSID.Text, QDate);
                    MarkBind();
                    return;
                }
                Marks = bMark.SelectMark(txtSID.Text);
                MarkBind();
                return;
            }

            if (!string.IsNullOrEmpty(TxtFromDate.Text))
            {
                QDate[0] = Convert.ToDateTime(TxtFromDate.Text);
                if (!string.IsNullOrEmpty(TxtToDate.Text))
                {
                    QDate[1] = Convert.ToDateTime(TxtToDate.Text);
                }
                Marks = bMark.SelectMark(QDate);
                MarkBind();
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtToDate.Text))
                {
                    QDate[1] = Convert.ToDateTime(TxtToDate.Text);
                    Marks = bMark.SelectMark(QDate);
                    MarkBind();
                    return;
                }
            }  
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            QueryMark();
        }

        private void FormQuery_Load(object sender, EventArgs e)
        {
            MarkBind();
        }

        public static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        } 

        private void GridViewMark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CIndex = e.ColumnIndex;
            //ɾ������
            if(CIndex==4)
            {
                MarkBLL bMark = new MarkBLL();
                if (bMark.DeleteMark(GridViewMark.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("ɾ���ɹ�");
                    QueryMark();
                }
                else
                    MessageBox.Show("ɾ��ʧ��");
            }
                //�޸Ĳ���
            else if (CIndex == 5)
            {
                MarkBLL bMark = new MarkBLL();
                int mark = 0;           

                try
                {
                    if (!IsInt(GridViewMark.Rows[e.RowIndex].Cells[2].Value.ToString()))
                        throw new Exception("���������");
                    mark = Convert.ToInt16(GridViewMark.Rows[e.RowIndex].Cells[2].Value.ToString());
                    if (mark > MAXMARK || mark < MINMARK)
                        throw new Exception("�ɼ���ΧԽ��");

                    if (bMark.ChangeMark(GridViewMark.Rows[e.RowIndex].Cells[0].Value.ToString(), mark))
                    {
                        MessageBox.Show("���³ɹ�");
                        QueryMark();
                    }
                }                         
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "���󡣸���ʧ�ܡ�");
                    return;
                }
            }
        }

        private void FormQuery_Resize(object sender, EventArgs e)
        {
            GridViewMark.Height = this.Height - groupBox1.Height - 50;           
        }
    }
}