using GraduateStudent.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Entities.DTOs
{
    public class StudentLoginDTO : IDTO
    {
        public string SchoolNumber { get; set; }

        public string Password { get; set; }
    }
}
