using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduateStudent.Bll.Abstract;
using GraduateStudent.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduateStudent.WebUI.Controllers
{
    public class AccountController : Controller
    {
        IStudentService _studentService;

        public AccountController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(StudentLoginDTO studentLoginDTO)
        {
            var isLogin = _studentService.LoginControl(studentLoginDTO);
            if (isLogin)
            {

                var student = _studentService.GetDetail(studentLoginDTO.SchoolNumber);
                HttpContext.Session.SetString("id", student.Id.ToString());
                HttpContext.Session.SetString("fullname", student.FullName);
                HttpContext.Session.SetString("department", student.Department.Name);
                HttpContext.Session.SetString("schoolNumber", student.SchoolNumber);
                HttpContext.Session.SetString("TcNo", student.TC);
                HttpContext.Session.SetString("telephoneNumber", student.TelephoneNumber);
                HttpContext.Session.SetString("birthdayDate", Convert.ToDateTime(student.BirthdayDate).ToShortDateString());
                HttpContext.Session.SetString("email", student.Email);
                HttpContext.Session.SetString("graduateYear", student.GraduateYear.ToString());
                HttpContext.Session.SetString("registrationDate", Convert.ToDateTime(student.RegistrationDate).ToShortDateString());

                return RedirectToAction("Index", "Student");
            }
            TempData["Failed"] = "Giriş Başarısız";
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(StudentLoginDTO studentLoginDTO)
        {
            if (studentLoginDTO != null)
            {
                TempData["RegisterControl"] = _studentService.RegisterControl(studentLoginDTO);
            }
            return View();
        }
        public IActionResult PasswordForgot()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PasswordForgot(PasswordForgotDTO passwordForgotDTO)
        {
            var password = _studentService.PasswordForgot(passwordForgotDTO);
            TempData["password"] = password;
            return View();
        }
    }
}