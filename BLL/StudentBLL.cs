using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassQuestionMark.Model;
using System.Data;

namespace ClassQuestionMark.BLL
{
    public class StudentBLL
    {
        private ClassQuestionMarkEntities cqme = new ClassQuestionMarkEntities();

        public IList<StudentInfo> GetStudentByClass(string pClassID)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;
            if (cqme.TheoryClass.Where(x=>x.TheoryClassID==pClassID).Count()>0)
            {
                return GetStudentByTheoryClass(pClassID);
            }

            if (cqme.LabClass.Where(x => x.LabClassID == pClassID).Count() > 0)
            {
                return GetStudentByLabClass(pClassID);
            }

            return null;
        }

        private IList<StudentInfo> GetStudentByLabClass(string pClassID)
        {
            var students = cqme.StudentInfo.Where(x => x.LabClassID == pClassID);

            if (students.Count()>0)
            {
                return students.ToList();
            }
            return null;
        }

        private IList<StudentInfo> GetStudentByTheoryClass(string pClassID)
        {
            var students= from stu in cqme.StudentInfo                          
                          where stu.LabClass.TheoryClassID==pClassID
                          select stu;

            if (students.Count() > 0)
            {
                return students.ToList();
            }

            return null;
        }

        public StudentInfo GetStudentBySID(string pSID)
        {
            if (string.IsNullOrEmpty(pSID))
                return null;
            var student = cqme.StudentInfo.Where(x => x.SID == pSID);
            if (student.Count()>0)
            {
                return student.First();
            }
            return null;
        }

        public StudentInfo GetStudentByName(string pSname)
        {
            if (string.IsNullOrEmpty(pSname))
                return null;
            var student = cqme.StudentInfo.Where(x => x.SName == pSname);
            if (student.Count() > 0)
            {
                return student.First();
            }
            return null;
        }

        public IList<string> GetSIDByClass(string pClassID)
        {
            if (string.IsNullOrEmpty(pClassID))
                return null;

            IEnumerable<string> student = null;
            if (cqme.TheoryClass.Where(x => x.TheoryClassID == pClassID).Count() > 0)
            {
                student = from stu in cqme.StudentInfo
                          where stu.LabClass.TheoryClassID == pClassID
                          select stu.SID;
            }

            if (cqme.LabClass.Where(x => x.LabClassID == pClassID).Count() > 0)
            {
                student = from stu in cqme.StudentInfo
                          where stu.LabClass.TheoryClassID == pClassID
                          select stu.SID;
            }

            if (student.Count() > 0)
                return student.ToList();

            return null;
        }

        public bool ChangeRate(string pSID, int pRate)
        {
            if (string.IsNullOrEmpty(pSID))
                return false;

            var linqstr = cqme.StudentInfo.Where(x => x.SID == pSID);
            if (linqstr.Count() > 0)
            {
                StudentInfo student = linqstr.First();
                student.Rate = pRate;
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
            else
            {
                return false;
            }            
        }

        public IList<StudentInfo> GetReleaseStudent()
        {
            int free=Int32.Parse(Setting.FreeRate);
            var students = cqme.StudentInfo.Where(x => x.Rate>= free);

            if (students.Count() > 0)
                return students.ToList();

            return null;
        }

        public bool UpdateStudent(StudentInfo pStudent)
        {
            var linqstr = cqme.StudentInfo.Where(x => x.SID == pStudent.SID);
            if (linqstr.Count() > 0)
            {
                StudentInfo student = linqstr.First();
                student = pStudent;//不知直接修改引用是否正确
                try
                {
                    cqme.SaveChanges();
                }
                catch (Exception ex)
                {
                    
                    throw ex;
                }
                return true;

            }
            else
                return false;         
        }

        public bool AddStudent(StudentInfo pStudent)
        {
            if (string.IsNullOrEmpty(pStudent.SID))
                return false;

            if (string.IsNullOrEmpty(pStudent.SName))
                pStudent.SName = "";

            if (string.IsNullOrEmpty(pStudent.LabClassID))
                return false;

            try
            {
                cqme.StudentInfo.AddObject(pStudent);
                cqme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public bool BatchAdd(DataSet pDs)
        {
            StudentInfo stu = new StudentInfo();
            //bool final = true;
            foreach (DataRow dr in pDs.Tables[0].Rows)
            {
                stu = new StudentInfo();
                stu.SID=dr[0].ToString();
                stu.SName=dr[1].ToString();
                stu.LabClassID=dr[2].ToString();
                stu.Rate=Int32.Parse(dr[3].ToString());
                //出错会影响后面的数据
                //if (final)
                //    final = AddStudent(stu);
                cqme.StudentInfo.AddObject(stu);
            }
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
    }
}
