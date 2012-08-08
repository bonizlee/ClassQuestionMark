using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using System.Data.OleDb;
using System.IO; 

namespace WinCQM
{
    class ExportExcel
    {
         /**//// <summary>
        /// ��DataGridView�е����ݵ�����Excel�У���������ʾ����(�޼���ģ��)
        /// ֻ����һ��ĵ���Excel
        /// </summary>
        /// <param name="caption">Ҫ��ʾ��ҳͷ</param>
        /// <param name="date">��ӡ����</param>
        /// <param name="dgv">Ҫ���е�����DataGridView</param>
        public void ExportToExcel(string caption, string date, DataGridView dgv)
        {
            //DataGridView�ɼ�����
            int visiblecolumncount = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))
                {
                    visiblecolumncount++;
                }
            }

            try
            {
                //��ǰ�����е�����
                int currentcolumnindex = 1;
                //��ǰ�����е�����
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //����Ĭ�������С
                //���ñ�ͷ
                Mylxls.Caption = caption;
                //��ʾ��ͷ
                Mylxls.Cells[1, 1] = caption;
                //��ʾʱ��
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //�����ʾ
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).ColumnWidth = dgv.Columns[i].Width / 8;
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //����
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //������ʾ
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //�ϲ���Ԫ��
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //�и�
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "����";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //�����С
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //������ʾ
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //�ϲ�
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //�����ʾ
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //�п��

                object[,] dataArray = new object[dgv.Rows.Count, visiblecolumncount];

                //��ǰ�����е�����
                //int currentcolumnindex = 1;
                //��ǰ�����е�����
                for (int i = 0; i < dgv.Rows.Count; i++)   //ѭ���������
                {
                    currentcolumnindex = 1;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true && (dgv.Columns[j] is DataGridViewTextBoxColumn))
                        {
                            if (dgv[j, i].Value != null)  //�����Ԫ�����ݲ�Ϊ��
                            {
                                dataArray[i, currentcolumnindex - 1] = dgv[j, i].Value.ToString();
                            }
                            currentcolumnindex++;
                        }
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[4, 1], Mylxls.Cells[dgv.Rows.Count + 3, visiblecolumncount]).Value2 = dataArray; //���ñ߿�
                Mylxls.get_Range(Mylxls.Cells[4, 1], Mylxls.Cells[dgv.Rows.Count + 3, visiblecolumncount]).Cells.Borders.LineStyle = 1; //���ñ߿�
                Mylxls.Visible = true;

            }
            catch
            {
                MessageBox.Show("��Ϣ����ʧ�ܣ���ȷ����Ļ�����װ��Microsoft Office Excel 2003��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /**//// <summary>
        /// ��DataGridView�е����ݵ�����Excel�У���������ʾ����(����ģ��)
        /// �����ڵ����Ѷ����ģ���Excel��������Ҫ�硰Ѯ���������±�����
        /// ��ע�⣺ģ��Ӧ����Ӧ�����PrintTemplateĿ¼��

        /// </summary>
        /// <param name="ModelName">ģ�������</param>
        /// <param name="Date">��ӡ����</param>
        /// <param name="dgv">Ҫ���е�����DataGridView</param>
        public void ExportToExcelByModel(string ModelName, string Date, DataGridView dgv)
        {
            Microsoft.Office.Interop.Excel.Application m_objExcel = null;
            Microsoft.Office.Interop.Excel._Workbook m_objBook = null;
            Microsoft.Office.Interop.Excel.Sheets m_objSheets = null;
            Microsoft.Office.Interop.Excel._Worksheet m_objSheet = null;
            object m_objOpt = System.Reflection.Missing.Value;
            try
            {
                m_objExcel = new Microsoft.Office.Interop.Excel.Application();
                string path = System.Windows.Forms.Application.StartupPath.ToString().Replace("\\bin\\Debug", "") + "\\PrintTemplate\\";
                path = path + ModelName;
                m_objBook = m_objExcel.Workbooks.Open(path, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt, m_objOpt);

                m_objSheets = (Microsoft.Office.Interop.Excel.Sheets)m_objBook.Worksheets;
                m_objSheet = (Microsoft.Office.Interop.Excel._Worksheet)(m_objSheets.get_Item(1));

                //�������
                m_objExcel.Cells[2, 1] = Date.ToString();

                //��ǰ�����е�����
                int currentcolumnindex = 1;
                //��ǰ�����е�����
                int currentrowindex = 4;
                for (int i = 0; i < dgv.Rows.Count; i++)   //ѭ���������
                {
                    currentcolumnindex = 1;
                    currentrowindex = 4 + i;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true)
                        {
                            if (dgv[j, i].Value != null)  //�����Ԫ�����ݲ�Ϊ��
                            {
                                m_objExcel.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                            }
                            m_objExcel.get_Range(m_objExcel.Cells[currentrowindex, currentcolumnindex], m_objExcel.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                            currentcolumnindex++;
                        }
                    }
                }
                m_objExcel.DisplayAlerts = false;
                m_objExcel.Visible = true;
                System.Runtime.InteropServices.Marshal.ReleaseComObject(m_objBook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(m_objExcel);
            }
            catch
            {
                MessageBox.Show("��Ϣ����ʧ�ܣ���ȷ����Ļ�����װ��Microsoft Office Excel 2003����ģ��δ��ɾ����", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }


        /**//// <summary>
        /// ��DataGridView�е����ݵ�����Excel�У���������ʾ����(�޼���ģ��)
        /// ֻ�����кϲ���ĵ�������������˵�ĺϲ�����ָ����е�Ԫ���ֵΪ��ʱ�Զ�����һ�еĵ�λ����кϲ�
        /// </summary>
        /// <param name="caption">Ҫ��ʾ��ҳͷ</param>
        /// <param name="date">��ӡ����</param>
        /// <param name="dgv">Ҫ���е�����DataGridView</param>
        /// <param name="MergeCount">�ϲ�������,û���õ�</param>
        public void ExportToExcelNullMerge(string caption, string date, DataGridView dgv, int MergeCount)
        {
            //DataGridView�ɼ�����
            int visiblecolumncount = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))
                {
                    visiblecolumncount++;
                }
            }

            try
            {
                //��ǰ�����е�����
                int currentcolumnindex = 1;
                //��ǰ�����е�����
                int currentrowindex = 4;
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //����Ĭ�������С
                //���ñ�ͷ
                Mylxls.Caption = caption;
                //��ʾ��ͷ
                Mylxls.Cells[1, 1] = caption;
                //��ʾʱ��
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //�����ʾ
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //����
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //������ʾ
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //�ϲ���Ԫ��

                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //�и�
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "����";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //�����С
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //������ʾ
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //�ϲ�
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //�����ʾ
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //�п��

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    currentcolumnindex = 1;
                    currentrowindex = 4 + i;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true && (dgv.Columns[j] is DataGridViewTextBoxColumn))
                        {
                            if (dgv[j, i].Value != null)  //�����Ԫ�����ݲ�Ϊ��
                            {
                                Mylxls.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                            }
                            Mylxls.get_Range(Mylxls.Cells[1, currentcolumnindex], Mylxls.Cells[1, currentcolumnindex]).ColumnWidth = dgv.Columns[j].Width / 8;
                            Mylxls.get_Range(Mylxls.Cells[currentrowindex, currentcolumnindex], Mylxls.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                            if (dgv.Rows[i].Cells[j].Value.ToString() == "")
                            {
                                Mylxls.get_Range(Mylxls.Cells[currentrowindex - 1, currentcolumnindex], Mylxls.Cells[currentrowindex, currentcolumnindex]).MergeCells = true;
                                //Mylxls.get_Range(Mylxls.Cells[i - 1, col + 2], Mylxls.Cells[rowIndex, col + 2]).MergeCells = true;
                                //Mylxls.get_Range(Mylxls.Cells[i - 1, col + 3], Mylxls.Cells[rowIndex, col + 3]).MergeCells = true;
                            }
                            currentcolumnindex++;
                        }
                    }
                }
                Mylxls.Visible = true;

            }
            catch
            {
                MessageBox.Show("��Ϣ����ʧ�ܣ���ȷ����Ļ�����װ��Microsoft Office Excel 2003��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /**//// <summary>
        /// ��DataGridView�е����ݵ�����Excel�У���������ʾ����(�޼���ģ��)
        /// ֻ�����кϲ���ĵ���,���ҿɸ���ǰ���DataGridViewCheckBoxColumn�Ƿ�ѡ����е���
        /// </summary>
        /// <param name="caption">Ҫ��ʾ��ҳͷ</param>
        /// <param name="date">��ӡ����</param>
        /// <param name="dgv">Ҫ���е�����DataGridView</param>
        /// <param name="MergeCount">�ϲ�������</param>
        public void ExportToExcelNullMergeHasCheckBox(string caption, string date, DataGridView dgv, int MergeCount)
        {
            //DataGridView�ɼ�����
            int visiblecolumncount = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))
                {
                    visiblecolumncount++;
                }
            }

            try
            {
                //��ǰ�����е�����
                int currentcolumnindex = 1;
                //��ǰ�����е�����
                int currentrowindex = 4;
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //����Ĭ�������С
                //���ñ�ͷ
                Mylxls.Caption = caption;
                //��ʾ��ͷ
                Mylxls.Cells[1, 1] = caption;
                //��ʾʱ��
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //�����ʾ
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //����
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //������ʾ
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //�ϲ���Ԫ��

                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //�и�
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "����";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //�����С
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //������ʾ
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //�ϲ�
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //�����ʾ
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //�п��

                currentrowindex = 3;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell dgvc = new DataGridViewCheckBoxCell();
                    dgvc = (DataGridViewCheckBoxCell)dgv[0, i];
                    if (dgvc.FormattedValue.ToString() == "True")
                    {
                        currentcolumnindex = 1;

                        currentrowindex++;
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if (dgv.Columns[j].Visible == true && (dgv.Columns[j] is DataGridViewTextBoxColumn))
                            {
                                if (dgv[j, i].Value != null)  //�����Ԫ�����ݲ�Ϊ��
                                {
                                    Mylxls.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                                }
                                Mylxls.get_Range(Mylxls.Cells[1, currentcolumnindex], Mylxls.Cells[1, currentcolumnindex]).ColumnWidth = dgv.Columns[j].Width / 8;
                                Mylxls.get_Range(Mylxls.Cells[currentrowindex, currentcolumnindex], Mylxls.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //���ñ߿�
                                if (dgv.Rows[i].Cells[j].Value.ToString() == "")
                                {
                                    for (int k = 0; k < MergeCount; k++)
                                    {
                                        Mylxls.get_Range(Mylxls.Cells[currentrowindex - 1, currentcolumnindex + k], Mylxls.Cells[currentrowindex, currentcolumnindex + k]).MergeCells = true;
                                    }
                                    //Mylxls.get_Range(Mylxls.Cells[i - 1, col + 2], Mylxls.Cells[rowIndex, col + 2]).MergeCells = true;
                                    //Mylxls.get_Range(Mylxls.Cells[i - 1, col + 3], Mylxls.Cells[rowIndex, col + 3]).MergeCells = true;
                                }
                                currentcolumnindex++;
                            }
                        }
                    }
                }
                Mylxls.Visible = true;

            }
            catch
            {
                MessageBox.Show("��Ϣ����ʧ�ܣ���ȷ����Ļ�����װ��Microsoft Office Excel 2003��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }


        /// <summary>
        /// ��ȡExcel�ĵ�
        /// </summary>
        /// <param name="Path">�ļ�����</param>
        /// <returns>����һ�����ݼ�</returns>
        public DataSet ExcelToDS(string Path)
        {
            try
            {
                if (!Path.EndsWith(".xls"))
                {
                    throw new Exception("ֻ�ܵ���Excel��ʽ���ļ�");
                }
                string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                DataSet ds = null;
                strExcel = "select * from [Sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strConn);
                ds = new DataSet();
                myCommand.Fill(ds, "table1");
                return ds;
            }
            catch (System.Data.OleDb.OleDbException ex)
            {
                System.Diagnostics.Debug.WriteLine("д��Excel��������" + ex.Message);
                return null;
            }
        }

    }
}
