using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduateStudent.Bll.Abstract;
using GraduateStudent.Entities.Concrete;
using GraduateStudent.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GraduateStudent.WebUI.Controllers
{

    public class HomeController : Controller
    {
        IStudentService _studentService;
        IDepartmentService _departmentService;

        public HomeController(IStudentService studentService,IDepartmentService departmentService)
        {
            _studentService = studentService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GraduateSearch()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GraduateSearch(StudentNumberDTO model)
        {
            if (model != null)
            {
                TempData["Message"] = _studentService.IsGraduateMessage(model);
            }
            return View();
        }

        public IActionResult GraduateStatistics()
        { 
            TempData["Associate"] = _studentService.AssociateDegreeCount();
            TempData["Undergraduate"]= _studentService.UndergraduateCount();
            TempData["TotalStudent"] = _studentService.TotalStudentCount();
            TempData["Graduatedfor2021"] = _studentService.GraduatedByYears();
            TempData["RegisteredSystem"] = _studentService.NumberOfStudentForRegistered();
            TempData["TotalDepartment"] = _departmentService.TotalDepartmentCount();

            return View();
        }
    }
}