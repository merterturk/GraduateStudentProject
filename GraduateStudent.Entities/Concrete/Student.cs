using GraduateStudent.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GraduateStudent.Entities.Concrete
{
    // Student Information
    public class Student : IEntity
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string FullName { get; set; }

        [Required,MaxLength(20)]
        public string TC { get; set; }

        [Required,MaxLength(20)]
        public string SchoolNumber { get; set; }

        public DateTime BirthdayDate { get; set; }

        [MaxLength(50)]
        public string TelephoneNumber { get; set; }

        [MaxLength(75)]
        public string Email { get; set; }

        public bool IsGraduate { get; set; }

        public int? GraduateYear { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

    }
}
