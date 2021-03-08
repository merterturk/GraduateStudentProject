using GraduateStudent.Bll.Abstract;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Bll.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        public void Delete(Department department)
        {
            _departmentDal.Delete(department);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public Department GetById(int departmentId)
        {
            return _departmentDal.Get(x => x.Id == departmentId);
        }

        public int TotalDepartmentCount()
        {
            return _departmentDal.TotalDepartmentCount();
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department);
        }
    }
}
