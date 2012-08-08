using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Xml;
using System.IO;
using System.Linq;

namespace ClassQuestionMark.BLL
{
    public abstract class Setting
    {
        protected static string FILEPATH = ConfigurationManager.AppSettings["SettingFile"].ToString();
        /// <summary>
        ///  读取某元素的内容
        /// </summary>
        /// <param name="pElementName">元素名称</param>
        /// <returns></returns>
        protected static string GetXMLContent(string pElementName)
        {
            string result = string.Empty;
            try
            {
                using (XmlReader xr = XmlReader.Create(FILEPATH))
                {
                    while (xr.Read())
                    {
                        if (xr.MoveToContent() == XmlNodeType.Element && xr.Name == pElementName)
                        {
                            result = xr.ReadString();
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected static bool SetXMLContent(string pElementName, string pText)
        {
            bool result = false;
            try
            {
                XmlDocument xd = new XmlDocument();
                xd.Load(FILEPATH);
                XmlNode node = xd.GetElementsByTagName(pElementName).Item(0);
                if (node != null)
                    node.InnerText = pText;
                else  //如果没有这个元素，则添加
                {
                    XmlNode root = xd.SelectSingleNode("Setting");
                    XmlElement xe = xd.CreateElement(pElementName);
                    xe.InnerText = pText;
                    root.AppendChild(xe);
                }
                xd.Save(FILEPATH);
                result = true;
            }
            catch (FileNotFoundException)
            {
                CreateXMLFile();
                throw new Exception("配置文件不存在，已重新初始化");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return result;
        }

        private static void CreateXMLFile()
        {

            XmlDocument xd = new XmlDocument();
            XmlNode xmldec = xd.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xd.AppendChild(xmldec);

            XmlElement xmlroot = xd.CreateElement("Setting");

            XmlElement xmlInitRate = xd.CreateElement("InitRate");
            xmlInitRate.InnerText = "0";

            XmlElement xmlBaseMark = xd.CreateElement("BaseMark");
            xmlBaseMark.InnerText = "70";

            XmlElement xmlFreeRate = xd.CreateElement("FreeRate");
            xmlFreeRate.InnerText = "20";

            XmlElement xmlGrade = xd.CreateElement("Grade");
            xmlGrade.InnerText = "-5;1;2;3;4;5";

            xmlroot.AppendChild(xmlInitRate);
            xmlroot.AppendChild(xmlBaseMark);
            xmlroot.AppendChild(xmlFreeRate);
            xmlroot.AppendChild(xmlGrade);
            xd.AppendChild(xmlroot);
            xd.Save(FILEPATH);
        }

        #region 初始机率
        public static string InitRate
        {
            get
            {
                try
                {
                    string strRate = GetXMLContent("InitRate");
                    if (strRate != string.Empty)
                        return strRate;
                    else
                        return "0";
                }
                catch
                {
                    //
                    return "0";
                }
            }
            set
            {
                try
                {
                    SetXMLContent("InitRate", value);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion

        #region 基础成绩
        public static string BaseMark
        {
            get
            {
                try
                {
                    string result = GetXMLContent("BaseMark");
                    if (result != string.Empty)
                        return result;
                    else
                        return "70";
                }
                catch
                {
                    return "70";
                }
            }
            set
            {
                try
                {
                    SetXMLContent("BaseMark", value);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion

        #region 免提问分数
        public static string FreeRate
        {
            get
            {
                try
                {
                    string result = GetXMLContent("FreeRate");
                    if (result != string.Empty)
                        return result;
                    else
                        return "20";
                }
                catch
                {
                    return "20";
                }
            }
            set
            {
                try
                {
                    SetXMLContent("FreeRate", value);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion

        #region 评分等级
        public static IList<string> Grades
        {
            get
            {
                IList<string> grades = new List<string>();
                try
                {
                    string gradestring = GetXMLContent("Grade");
                    string[] gstring;
                    if (gradestring != string.Empty)
                    {
                        gstring = gradestring.Split(';');                        
                    }
                    else
                    {
                        //读不到内容则返回默认值
                        gstring = "-5;1;2;3;4;5".Split(';');
                    }

                    foreach (string str in gstring)
                    {
                        grades.Add(str);
                    }
                    return grades;
                }
                catch
                {
                    string[] gstring ={ "-5", "1", "2", "3", "4", "5" };
                    foreach (string str in gstring)
                    {
                        grades.Add(str);
                    }
                    return grades;
                }
            }

            set
            {
                StringBuilder prepare = new StringBuilder();
                foreach (string str in value)
                {
                    prepare.Append(str);
                    prepare.Append(";");
                }
                prepare.Remove(prepare.Length - 1, 1);
                try
                {
                    SetXMLContent("Grade", prepare.ToString());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion

        #region 整型等级分数
        public static IList<int> IntGrades
        {
            get
            {
                List<int> grade = new List<int>();
                foreach (string str in Grades)
                {
                    grade.Add(int.Parse(str));
                }
                return grade;
            }
        }
        #endregion

        #region 最高等级分
        public static int MaxGrade
        {
            get
            {
                return IntGrades.Max();
            }
        }
        #endregion

        #region MyRegion
        public static int MinGrade
        {
            get
            {
                return IntGrades.Min();
            }
        }	
        #endregion
    }
}
