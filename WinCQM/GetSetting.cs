using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Configuration;
using System.Xml;

namespace WinCQM
{
    public abstract class GetSetting
    {
        protected static string FILEPATH = ConfigurationManager.AppSettings["SettingFile"].ToString();

        #region 初始机率
        public static string InitRate
        {
            get
            {
                try
                {
                    using (XmlReader xr = XmlReader.Create(FILEPATH))
                    {
                        while (xr.Read())
                        {
                            if (xr.MoveToContent() == XmlNodeType.Element && xr.Name == "InitRate")
                            {
                                string strRate = xr.ReadString();
                                if (strRate != string.Empty)
                                    return strRate;
                            }
                        }
                    }
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
               //
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
                    using (XmlReader xr = XmlReader.Create(FILEPATH))
                    {
                        while (xr.Read())
                        {
                            if (xr.MoveToContent() == XmlNodeType.Element && xr.Name == "BaseMark")
                            {
                                string result = xr.ReadString();
                                if (result != string.Empty)
                                    return result;
                            }
                        }
                    }
                    return "70";
                }
                catch
                {                   
                    return "70";
                }
            }
            set
            {
                //
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
                    using (XmlReader xr = XmlReader.Create(FILEPATH))
                    {
                        while (xr.Read())
                        {
                            if (xr.MoveToContent() == XmlNodeType.Element && xr.Name == "FreeRate")
                            {
                                string result = xr.ReadString();
                                if (result != string.Empty)
                                    return result;
                            }
                        }
                    }
                    return "20";
                }
                catch
                {
                    return "20";
                }
            }
        }
        #endregion

        #region 评分等级
        public static string[] Grades
        {
            get
            {
                try
                {
                    using (XmlReader xr = XmlReader.Create(FILEPATH))
                    {                        
                        while (xr.Read())
                        {
                            if (xr.MoveToContent() == XmlNodeType.Element && xr.Name == "Grade")
                            {
                                string rg = xr.ReadString();
                                if (rg != string.Empty)
                                {
                                    string[] gstring = rg.Split(';');
                                    return gstring;
                                }
                            }
                        }
                        string[] rstring ={ "-5", "1", "2", "3", "4", "5" };
                        return rstring;                       
                    }
                }
                catch 
                {                    
                    
                    string[] gstring={"-5","1","2","3","4","5"};
                    return gstring;
                }
            }

            set
            {
                try
                {
                    XmlDocument xd = new XmlDocument();
                    xd.Load(FILEPATH);
                    XmlNode root = xd.DocumentElement;
                    XmlNode grade = root.SelectSingleNode("Grade");
                    //
                     
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        #endregion
    }
}
