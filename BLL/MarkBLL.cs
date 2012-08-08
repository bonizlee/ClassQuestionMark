using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ClassQuestionMark.Model;


namespace ClassQuestionMark.BLL
{
    public class MarkBLL
    {
        ClassQuestionMarkEntities cqme = new ClassQuestionMarkEntities();

        public bool AddMark(string pMarkID, string pSID, int pMark, DateTime pDate)
        {
            if (string.IsNullOrEmpty(pMarkID) && string.IsNullOrEmpty(pSID))
                return false;

            MarkInfo mark = new MarkInfo();
            mark.MarkID = pMarkID;
            mark.SID = pSID;
            mark.Mark = pMark;
            mark.Date = pDate;

            try
            {
                cqme.MarkInfo.AddObject(mark);
                cqme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        string AddZero(string pMatch)
        {
            if (Convert.ToInt16(pMatch) < 10)
            {
                pMatch = "0" + pMatch;
            }
            return pMatch;
        }

        public bool AddMark(string pSID, int pMark)
        {
            string MarkID = DateTime.Now.Year.ToString();
            MarkID += AddZero(DateTime.Now.Month.ToString());
            MarkID += AddZero(DateTime.Now.Day.ToString());
            MarkID += AddZero(DateTime.Now.Hour.ToString());
            MarkID += AddZero(DateTime.Now.Minute.ToString());
            MarkID += AddZero(DateTime.Now.Second.ToString());
            if (string.IsNullOrEmpty(pSID))
                return false;
            return AddMark(MarkID, pSID, pMark, DateTime.Now);
        }

        public IList<MarkInfo> SelectMark(string pSID)
        {
            if(string.IsNullOrEmpty(pSID))
                return null;
            var marks = cqme.MarkInfo.Where(x => x.SID == pSID);
            if (marks.Count()>0)
            {
                return marks.ToList();
            }
            return null;
        }

        /// <summary>
        ///  根据日期范围查询成绩
        /// </summary>
        /// <param name="pDate">第一个日期是上界，第二个日期是下界</param>
        /// <returns></returns>
        public IList<MarkInfo> SelectMark(DateTime[] pDate)
        {
            IQueryable<MarkInfo> marks=null;
            DateTime StartDate = pDate[0];
            DateTime EndDate=pDate[1];
            if (StartDate != new DateTime()) //上界日期不为空
            {
                if (EndDate != new DateTime())//两个日期都不为空
                {
                    marks = from m in cqme.MarkInfo
                            where m.Date >= StartDate && m.Date <= EndDate
                            select m;
                }
                else //下界为空
                {
                    marks = from m in cqme.MarkInfo
                            where m.Date >= StartDate 
                            select m;
                }
            }
            else if (EndDate != new DateTime())//下界日期不为空，上界日期为空
            {
                marks = from m in cqme.MarkInfo
                        where m.Date <= EndDate
                        select m;
            }

            if (marks != null && marks.Count() > 0)
            {
                return marks.ToList();
            }
            return null;

        }

        public IList<MarkInfo> SelectMark(string pSID, DateTime[] pDate)
        {
            IQueryable<MarkInfo> marks = null;
            DateTime StartDate = pDate[0];
            DateTime EndDate = pDate[1];

            if (StartDate != new DateTime()) //上界日期不为空
            {
                if (EndDate != new DateTime())//两个日期都不为空
                {
                    marks = from m in cqme.MarkInfo
                            where m.Date >= StartDate && m.Date <= EndDate && m.SID == pSID
                            select m;
                }
                else //下界为空
                {
                    marks = from m in cqme.MarkInfo
                            where m.Date >= StartDate && m.SID == pSID
                            select m;
                }
            }
            else if (EndDate != new DateTime())//下界日期不为空，上界日期为空
            {
                marks = from m in cqme.MarkInfo
                        where m.Date <= EndDate && m.SID == pSID
                        select m;
            }

            if (marks != null && marks.Count() > 0)
            {
                return marks.ToList();
            }
            return null;
        }

        public bool ChangeMark(string pMarkID, int pMark)
        {
            var linqstr= cqme.MarkInfo.Where(x => x.MarkID == pMarkID);
            if (linqstr.Count()==0)
            {
                return false;                
            }

            MarkInfo mark = linqstr.First();
            mark.Mark = pMark;

            try
            {
                cqme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        public bool DeleteMark(string pMarkID)
        {
            var linqstr = cqme.MarkInfo.Where(x => x.MarkID == pMarkID);
            if (linqstr.Count() == 0)
            {
                return false;
            }

            MarkInfo mark = linqstr.First();

           
            try
            {
                cqme.DeleteObject(mark);
                cqme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
           
        }

        public IList<StudentInfo> FinalMark(string pClassID, int pBase)
        {
            int baseMark = new int();
            IList<StudentInfo> StudentMark = new List<StudentInfo>();
            StudentBLL bStudent = new StudentBLL();
            StudentMark = bStudent.GetStudentByClass(pClassID);
            IList<MarkInfo> PMark = new List<MarkInfo>();
            foreach (StudentInfo stu in StudentMark)
            {
                baseMark = pBase;                
                PMark = SelectMark(stu.SID);
                stu.Rate = baseMark;
                if (PMark==null)
                {
                    continue;
                }
                foreach (MarkInfo gMark in PMark)
                {
                    stu.Rate += gMark.Mark;
                }
                PMark.Clear();
                if (stu.Rate > 100)
                    stu.Rate = 100;
                if (stu.Rate < 0)
                    stu.Rate = 0;
            }

            return StudentMark;            
        }
    }
}
