using GraduateStudent.Bll.Abstract;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Entities.Concrete;
using GraduateStudent.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraduateStudent.Bll.Concrete
{
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetById(int studentId)
        {
            return _studentDal.Get(x => x.Id == studentId);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }
        public string IsGraduateMessage(StudentNumberDTO studentNumber)
        {
          return _studentDal.IsGraduateMessage(studentNumber);
        }

        public int UndergraduateCount()
        {
            return _studentDal.UndergraduateCount();
        }

        public int AssociateDegreeCount()
        {
            return _studentDal.AssociateDegreeCount();
        }
        public int TotalStudentCount()
        {
            return _studentDal.TotalStudentCount();
        }

        public int GraduatedByYears()
        {
            return _studentDal.GraduatedByYears();
        }

        public int NumberOfStudentForRegistered()
        {
            return _studentDal.NumberOfStudentForRegistered();
        }

        public string RegisterControl(StudentLoginDTO studentLogin)
        {
           return _studentDal.RegisterControl(studentLogin);
        }

        public bool LoginControl(StudentLoginDTO studentLogin)
        {
            return _studentDal.LoginControl(studentLogin);
        }

        public Student GetDetail(string schoolNumber)
        {
            return _studentDal.GetDetail(schoolNumber);
        }

        public string PasswordForgot(PasswordForgotDTO passwordForgot)
        {
            return _studentDal.PasswordForgot(passwordForgot);
        }
    }
}
