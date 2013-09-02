using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ClassQuestionMark.Model;

namespace ClassQuestionMark.BLL
{
    public class SelectorBLL
    {
        ClassQuestionMarkEntities cqme = new ClassQuestionMarkEntities();

        public IList<StudentInfo> SelectByClassID(string pClassID)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;
            StudentBLL stubll = new StudentBLL();
            return stubll.GetStudentByClass(pClassID);
        }        

        public int GetAverageRateByClass(string pClassID)
        {
            int average = 0;
            if (string.IsNullOrEmpty(pClassID))
                return average;
            StudentBLL stubll = new StudentBLL();
            IList<StudentInfo> studetns = stubll.GetStudentByClass(pClassID);

            if (studetns!=null)
            {
                average = (int)(from s in studetns
                           select s.Rate
                             ).Average();
            }

            return average;
        }

        public IList<string> GetSIDBelowAve(string pClassID)
        {
            return GetSIDBelowAve(pClassID, GetAverageRateByClass(pClassID));
        }

        public IList<string> GetSIDBelowAve(string pClassID, int pAverage)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;
            var linqstr =from s in cqme.StudentInfo
                             where s.Rate<=pAverage
                             select s.SID;

            if (linqstr.Count()>0)
            {
                return linqstr.ToList();
            }
            return null;
        }

        public IList<string> GetSIDUponAve(string pClassID)
        {
            return GetSIDUponAve(pClassID, GetAverageRateByClass(pClassID));
        }

        public IList<string> GetSIDUponAve(string pClassID, int pAverage)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;
            int free = Int32.Parse(Setting.FreeRate);

            var linqstr = from s in cqme.StudentInfo
                          where s.Rate > pAverage && s.Rate<= free
                          select s.SID;

            if (linqstr.Count() > 0)
            {
                return linqstr.ToList();
            }
            return null;
        }

        public IList<string> GetRandomList(string pClassID)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;
            IList<string> RandomID = new List<string>();          
            IList<string> BelowID = GetSIDBelowAve(pClassID);
            IList<string> UponID = GetSIDUponAve(pClassID);

            int BelowCount = 0;
            int UponCount = 0;
            int TotalCount = 0;
            if (BelowID==null)
            {
                if (UponID==null)
                {
                    return null;
                }
                else
                {
                    UponCount = UponID.Count;     
                }
            }
            else if ( UponID==null)
            {
                BelowCount = BelowID.Count;
            }
            else
            {
                BelowCount = BelowID.Count;
                UponCount = UponID.Count;     
            }

            TotalCount = BelowCount + UponCount;
            int RandomCount = 1;
            Random rand = new Random();
            int tempRand = 0;
            int seporate = 19;
            while (RandomID.Count < TotalCount)
            {
                //每19个低分段的学生插入一个高分段学生
                if ((RandomCount % seporate == 0 || BelowCount == 0) && UponCount > 0)
                {
                    tempRand = rand.Next(UponID.Count);
                    RandomID.Add(UponID[tempRand]);
                    UponID.RemoveAt(tempRand);
                    ++RandomCount;
                    UponCount = UponID.Count; 
                }
                else
                {
                    tempRand = rand.Next(BelowID.Count);
                    RandomID.Add(BelowID[tempRand]);
                    BelowID.RemoveAt(tempRand);
                    ++RandomCount;
                    BelowCount = BelowID.Count;
                }
            }
            return RandomID;
        }

    }
}
