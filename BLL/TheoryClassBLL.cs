using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassQuestionMark.Model;

namespace ClassQuestionMark.BLL
{
    public class TheoryClassBLL
    {
         ClassQuestionMarkEntities cqmdb = new ClassQuestionMarkEntities();
        public IList<TheoryClass> GetAllTheoryClass()
        {
           
            if (cqmdb.TheoryClass.Count() > 0)
            {
                return cqmdb.TheoryClass.ToList();
            }
            return null;
        }

        public bool AddClass(TheoryClass pClass)
        {
            if (string.IsNullOrEmpty(pClass.TheoryClassID))
                return false;
            if (string.IsNullOrEmpty(pClass.TheoryClassRoom))
                pClass.TheoryClassRoom = "";
            if (string.IsNullOrEmpty(pClass.Date))
                pClass.Date = "";

            try
            {
                cqmdb.TheoryClass.AddObject(pClass);
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
