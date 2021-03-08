using GraduateStudent.Core.DataAccess;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateStudent.Dal.Concrete.EntityFramework
{
    public class EfDepartmentDal : BaseRepository<Department, GraduateStudentContext>, IDepartmentDal
    {
        public int TotalDepartmentCount()
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Departments.Count();
            }
        }
    }
}
