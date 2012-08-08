using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassQuestionMark.Model;

namespace ClassQuestionMark.BLL
{
    public class LabClassBLL
    {
        ClassQuestionMarkEntities cqmdb = new ClassQuestionMarkEntities();
        public IList<LabClass> GetAllLabClass()
        {
            
            if (cqmdb.LabClass.Count()>0)
            {
                return cqmdb.LabClass.ToList();
            }            
            return null;
        }

        public IList<LabClass> GetLabClassByTheoryClss(string TheoryClassID)
        {
            
            var classes=cqmdb.LabClass.Where(x=>x.TheoryClassID==TheoryClassID);
            if (classes.Count() > 0)
            {
                return classes.ToList();
            }
            return null;
        }

        public bool AddClass(LabClass pClass)
        {
            if (string.IsNullOrEmpty(pClass.LabClassID))
                return false;
            if (string.IsNullOrEmpty(pClass.LabClassRoom))
                pClass.LabClassRoom = "";
            if (string.IsNullOrEmpty(pClass.Date))
                pClass.Date = "";

            try
            {
                cqmdb.LabClass.AddObject(pClass);
                cqmdb.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }                     
        }

    }

}
