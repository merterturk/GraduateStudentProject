using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GraduateStudent.Bll.Abstract
{
   public interface IDepartmentService
    {
        List<Department> GetAll();

        Department GetById(int departmentId);

        void Add(Department department);

        void Update(Department department);

        void Delete(Department department);

        int TotalDepartmentCount();
    }
}
