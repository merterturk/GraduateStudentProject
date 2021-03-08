using GraduateStudent.Core.DataAccess;
using GraduateStudent.Entities.Concrete;
using GraduateStudent.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Dal.Abstract
{
   public interface IStudentDal : IRepository<Student>
    {
        string IsGraduateMessage(StudentNumberDTO studentNumber);

        int UndergraduateCount();

        int AssociateDegreeCount();

        int TotalStudentCount();

        int GraduatedByYears();

        int NumberOfStudentForRegistered();

        string RegisterControl(StudentLoginDTO studentLogin);

        bool LoginControl(StudentLoginDTO studentLogin);

        Student GetDetail(string schoolNumber);

        string PasswordForgot(PasswordForgotDTO passwordForgot);

    }
}
