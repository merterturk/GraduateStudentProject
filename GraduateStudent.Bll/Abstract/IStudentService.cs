using GraduateStudent.Entities.Concrete;
using GraduateStudent.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Bll.Abstract
{
   public interface IStudentService
    {
        List<Student> GetAll();

        Student GetById(int studentId);

        void Add(Student student);

        void Update(Student student);

        void Delete(Student student);

        string IsGraduateMessage(StudentNumberDTO studentNumber);

        int UndergraduateCount();

        int AssociateDegreeCount();

        int TotalStudentCount(); 

        int GraduatedByYears(); // Total students who graduated for 2021

        int NumberOfStudentForRegistered(); //Total number of students enrolled in the system

        string RegisterControl(StudentLoginDTO studentLogin);

        bool LoginControl(StudentLoginDTO studentLogin);

        Student GetDetail(string schoolNumber);

        string PasswordForgot(PasswordForgotDTO passwordForgot);
    }
}
