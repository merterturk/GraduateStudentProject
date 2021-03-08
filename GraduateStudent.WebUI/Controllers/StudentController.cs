using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraduateStudent.Bll.Abstract;
using GraduateStudent.WebUI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
namespace GraduateStudent.WebUI.Controllers
{
    [UserFilter]
    public class StudentController : Controller
    {
        IAnnouncementService _announcementService;
        public StudentController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            TempData["id"] = HttpContext.Session.GetString("id");
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Announcement()
        {
            var getAll = _announcementService.GetAll();
            return View(getAll);
        }
        public IActionResult AnnouncementDetail(int id)
        {
            var getAnnouncement = _announcementService.GetById(id);
            return View(getAnnouncement);
        }




    }
}