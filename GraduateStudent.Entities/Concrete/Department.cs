using GraduateStudent.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GraduateStudent.Entities.Concrete
{
    // Department Information
   public class Department: IEntity
    {
        public Department()
        {
            Students = new List<Student>();
        }
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int DepartmentYear { get; set; }

        public IEnumerable<Student> Students { get; set; }
    }
}
