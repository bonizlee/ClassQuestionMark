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
        /// 将DataGridView中的数据导出到Excel中，并加载显示出来(无加载模板)
        /// 只用于一般的导出Excel
        /// </summary>
        /// <param name="caption">要显示的页头</param>
        /// <param name="date">打印日期</param>
        /// <param name="dgv">要进行导出的DataGridView</param>
        public void ExportToExcel(string caption, string date, DataGridView dgv)
        {
            //DataGridView可见列数
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
                //当前操作列的索引
                int currentcolumnindex = 1;
                //当前操作行的索引
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //设置默认字体大小
                //设置标头
                Mylxls.Caption = caption;
                //显示表头
                Mylxls.Cells[1, 1] = caption;
                //显示时间
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //如果显示
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).ColumnWidth = dgv.Columns[i].Width / 8;
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //粗体
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; //居中显示
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //合并单元格
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //行高
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "黑体";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //字体大小
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中显示
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //合并
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //左边显示
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //列宽度

                object[,] dataArray = new object[dgv.Rows.Count, visiblecolumncount];

                //当前操作列的索引
                //int currentcolumnindex = 1;
                //当前操作行的索引
                for (int i = 0; i < dgv.Rows.Count; i++)   //循环填充数据
                {
                    currentcolumnindex = 1;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true && (dgv.Columns[j] is DataGridViewTextBoxColumn))
                        {
                            if (dgv[j, i].Value != null)  //如果单元格内容不为空
                            {
                                dataArray[i, currentcolumnindex - 1] = dgv[j, i].Value.ToString();
                            }
                            currentcolumnindex++;
                        }
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[4, 1], Mylxls.Cells[dgv.Rows.Count + 3, visiblecolumncount]).Value2 = dataArray; //设置边框
                Mylxls.get_Range(Mylxls.Cells[4, 1], Mylxls.Cells[dgv.Rows.Count + 3, visiblecolumncount]).Cells.Borders.LineStyle = 1; //设置边框
                Mylxls.Visible = true;

            }
            catch
            {
                MessageBox.Show("信息导出失败，请确认你的机子上装有Microsoft Office Excel 2003！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /**//// <summary>
        /// 将DataGridView中的数据导出到Excel中，并加载显示出来(加载模板)
        /// 仅用于导出已定义好模版的Excel导出，主要如“旬报表”，“月报表”等
        /// 请注意：模板应放在应程序的PrintTemplate目录下

        /// </summary>
        /// <param name="ModelName">模版的名称</param>
        /// <param name="Date">打印日期</param>
        /// <param name="dgv">要进行导出的DataGridView</param>
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

                //填充日期
                m_objExcel.Cells[2, 1] = Date.ToString();

                //当前操作列的索引
                int currentcolumnindex = 1;
                //当前操作行的索引
                int currentrowindex = 4;
                for (int i = 0; i < dgv.Rows.Count; i++)   //循环填充数据
                {
                    currentcolumnindex = 1;
                    currentrowindex = 4 + i;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true)
                        {
                            if (dgv[j, i].Value != null)  //如果单元格内容不为空
                            {
                                m_objExcel.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                            }
                            m_objExcel.get_Range(m_objExcel.Cells[currentrowindex, currentcolumnindex], m_objExcel.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
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
                MessageBox.Show("信息导出失败，请确认你的机子上装有Microsoft Office Excel 2003并且模版未被删除！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }


        /**//// <summary>
        /// 将DataGridView中的数据导出到Excel中，并加载显示出来(无加载模板)
        /// 只用于有合并项的导出，我这里所说的合并项是指如果有单元格的值为空时自动与上一行的单位格进行合并
        /// </summary>
        /// <param name="caption">要显示的页头</param>
        /// <param name="date">打印日期</param>
        /// <param name="dgv">要进行导出的DataGridView</param>
        /// <param name="MergeCount">合并的列数,没有用到</param>
        public void ExportToExcelNullMerge(string caption, string date, DataGridView dgv, int MergeCount)
        {
            //DataGridView可见列数
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
                //当前操作列的索引
                int currentcolumnindex = 1;
                //当前操作行的索引
                int currentrowindex = 4;
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //设置默认字体大小
                //设置标头
                Mylxls.Caption = caption;
                //显示表头
                Mylxls.Cells[1, 1] = caption;
                //显示时间
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //如果显示
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //粗体
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中显示
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //合并单元格

                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //行高
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "黑体";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //字体大小
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中显示
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //合并
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //左边显示
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //列宽度

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    currentcolumnindex = 1;
                    currentrowindex = 4 + i;
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv.Columns[j].Visible == true && (dgv.Columns[j] is DataGridViewTextBoxColumn))
                        {
                            if (dgv[j, i].Value != null)  //如果单元格内容不为空
                            {
                                Mylxls.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                            }
                            Mylxls.get_Range(Mylxls.Cells[1, currentcolumnindex], Mylxls.Cells[1, currentcolumnindex]).ColumnWidth = dgv.Columns[j].Width / 8;
                            Mylxls.get_Range(Mylxls.Cells[currentrowindex, currentcolumnindex], Mylxls.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
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
                MessageBox.Show("信息导出失败，请确认你的机子上装有Microsoft Office Excel 2003！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        /**//// <summary>
        /// 将DataGridView中的数据导出到Excel中，并加载显示出来(无加载模板)
        /// 只用于有合并项的导出,并且可根据前面的DataGridViewCheckBoxColumn是否选择进行导出
        /// </summary>
        /// <param name="caption">要显示的页头</param>
        /// <param name="date">打印日期</param>
        /// <param name="dgv">要进行导出的DataGridView</param>
        /// <param name="MergeCount">合并的列数</param>
        public void ExportToExcelNullMergeHasCheckBox(string caption, string date, DataGridView dgv, int MergeCount)
        {
            //DataGridView可见列数
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
                //当前操作列的索引
                int currentcolumnindex = 1;
                //当前操作行的索引
                int currentrowindex = 4;
                Microsoft.Office.Interop.Excel.ApplicationClass Mylxls = new Microsoft.Office.Interop.Excel.ApplicationClass();
                Mylxls.Application.Workbooks.Add(true);
                //Mylxls.Cells.Font.Size = 10.5;   //设置默认字体大小
                //设置标头
                Mylxls.Caption = caption;
                //显示表头
                Mylxls.Cells[1, 1] = caption;
                //显示时间
                Mylxls.Cells[2, 1] = date;
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    if (dgv.Columns[i].Visible == true && (dgv.Columns[i] is DataGridViewTextBoxColumn))   //如果显示
                    {
                        Mylxls.Cells[3, currentcolumnindex] = dgv.Columns[i].HeaderText;
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
                        //Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).Font.Bold = true; //粗体
                        Mylxls.get_Range(Mylxls.Cells[3, currentcolumnindex], Mylxls.Cells[3, currentcolumnindex]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中显示
                        currentcolumnindex++;
                    }
                }
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).MergeCells = true; //合并单元格

                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).RowHeight = 30;   //行高
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Name = "黑体";
                //Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, 1]).Font.Size = 14;   //字体大小
                Mylxls.get_Range(Mylxls.Cells[1, 1], Mylxls.Cells[1, visiblecolumncount]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter; //居中显示
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).MergeCells = true; //合并
                Mylxls.get_Range(Mylxls.Cells[2, 1], Mylxls.Cells[2, 2]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft; //左边显示
                //Mylxls.get_Range(Mylxls.Cells[1, 2], Mylxls.Cells[1, 2]).ColumnWidth = 12;  //列宽度

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
                                if (dgv[j, i].Value != null)  //如果单元格内容不为空
                                {
                                    Mylxls.Cells[currentrowindex, currentcolumnindex] = dgv[j, i].Value.ToString();
                                }
                                Mylxls.get_Range(Mylxls.Cells[1, currentcolumnindex], Mylxls.Cells[1, currentcolumnindex]).ColumnWidth = dgv.Columns[j].Width / 8;
                                Mylxls.get_Range(Mylxls.Cells[currentrowindex, currentcolumnindex], Mylxls.Cells[currentrowindex, currentcolumnindex]).Cells.Borders.LineStyle = 1; //设置边框
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
                MessageBox.Show("信息导出失败，请确认你的机子上装有Microsoft Office Excel 2003！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }


        /// <summary>
        /// 读取Excel文档
        /// </summary>
        /// <param name="Path">文件名称</param>
        /// <returns>返回一个数据集</returns>
        public DataSet ExcelToDS(string Path)
        {
            try
            {
                if (!Path.EndsWith(".xls"))
                {
                    throw new Exception("只能导入Excel格式的文件");
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
                System.Diagnostics.Debug.WriteLine("写入Excel发生错误：" + ex.Message);
                return null;
            }
        }

    }
}
