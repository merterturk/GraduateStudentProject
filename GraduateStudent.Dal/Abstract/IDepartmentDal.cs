using GraduateStudent.Core.DataAccess;
using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Dal.Abstract
{
    public interface IDepartmentDal : IRepository<Department>
    {
        int TotalDepartmentCount();
    }
}
