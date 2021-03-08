using GraduateStudent.Core.DataAccess;
using GraduateStudent.Dal.Abstract;
using GraduateStudent.Dal.Constant;
using GraduateStudent.Entities.Concrete;
using GraduateStudent.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateStudent.Dal.Concrete.EntityFramework
{
    public class EfStudentDal : BaseRepository<Student, GraduateStudentContext>, IStudentDal
    {
      
        // This function returns a message to the user whether the student has graduated
        public string IsGraduateMessage(StudentNumberDTO studentNumber)
        {
            
           using(GraduateStudentContext context = new GraduateStudentContext())
            {
                var student = context.Students.SingleOrDefault(x => x.SchoolNumber == studentNumber.SchoolNumber);
                return student == null ? 
                      Messages.NoRecord : 
                    (student.IsGraduate == true ? Messages.Graduated : Messages.NotYetGraduated);
            }
        }
        // Return total number of associate degree graduates 
        public int AssociateDegreeCount()
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Where(x => x.Department.DepartmentYear == 2 && x.IsGraduate==true).Count();
            }
        }
         // Return total number of Undergraduate graduates 
        public int UndergraduateCount()
        {
            using (GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Where(x => x.Department.DepartmentYear == 4 && x.IsGraduate == true).Count();
            }
        }
        public int TotalStudentCount()
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Where(x=>x.IsGraduate==false).Count();
            }
        }

        public int GraduatedByYears()
        {
           using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Where(x => x.GraduateYear == 2021 && x.IsGraduate==true).Count();
            }
        }

        public int NumberOfStudentForRegistered()
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Where(x => x.RegistrationDate != null).Count();
            }
        }
        // Register Control And Update Student 
        public string RegisterControl(StudentLoginDTO studentLogin)
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                var result = context.Students.SingleOrDefault(x => x.SchoolNumber == studentLogin.SchoolNumber);
                if (result != null)
                {
                    if (result.IsGraduate)
                    {
                        if (string.IsNullOrEmpty(result.Password))
                        {
                            result.Password = studentLogin.Password;
                            result.RegistrationDate = DateTime.Now;
                            context.Students.Update(result);
                            context.SaveChanges();
                            return Messages.SuccessRecord;
                        }
                        else
                        {
                            return Messages.HasRecord;
                        }
                    }
                    else
                    {
                        return Messages.NotYetGraduated;
                    }
                }
                return Messages.NoRecord;
            }
        }

        public bool LoginControl(StudentLoginDTO studentLogin)
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                var result = context.Students.SingleOrDefault(x => x.SchoolNumber == studentLogin.SchoolNumber && x.Password == studentLogin.Password);
                if (result != null)
                {
                    return true;
                }
                return false;
            }
        }

        public Student GetDetail(string schoolNumber)
        {
           using(GraduateStudentContext context = new GraduateStudentContext())
            {
                return context.Students.Include("Department").SingleOrDefault(x => x.SchoolNumber == schoolNumber);
            }
        }

        public string PasswordForgot(PasswordForgotDTO passwordForgot)
        {
            using(GraduateStudentContext context = new GraduateStudentContext())
            {
                var password = context.Students.SingleOrDefault(p => p.SchoolNumber == passwordForgot.SchoolNumber && p.TC == passwordForgot.TC);


                if (password != null && password.IsGraduate && !(password.Password=="" || password.Password==null))
                {
                    return password.Password;
                }
                return Messages.NotMatchInformation;
                        
            }
        }
    }
}
