using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Services.Models;
using BackEnd.Services.Models.Entities;
using BackEnd.Services.Methods;
namespace High5WebApp.Controllers
{
    public class AdminController : Controller
    {
        AdminService adminService = new AdminService();
        FirstYearService firstYearService = new FirstYearService();

        // GET: Admin
        private readonly SchoolEntities database;
        public AdminController()
        {
            database = new SchoolEntities();
        }

        public ActionResult Main()
        {
            SchoolEntities data = new SchoolEntities();
    
            return View();
        }

        public ActionResult TeacherView()
        {
            var dat = database.teachers.ToList();
            return View(dat);
        }

        public ActionResult AddTeacherView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeacherView(Teacher teach)
        {
            AdminService adminService = new AdminService();
            adminService.AddTeacher(teach);
            return View();
        }


        public ActionResult StudentView()
        {
            var dat = database.student.ToList();
            return View(dat);
        }

        public ActionResult AddStudentView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudentView(Students stud)
        {
            adminService.AddStudents(stud);
            return View();
        }

        [HttpGet]
        public ActionResult EditTeacherView(int xid)
        {
            var chosen = adminService.getTeacherID(xid);
            return View(chosen);
        }

        [HttpPost]
        public ActionResult EditTeacherView(Teacher teach)
        {
            adminService.EditTeacher(teach);
            return View();
        }

        //FirstYear Views
        public ActionResult FirstYearView()
        {
            return View();
        }
        public ActionResult FirstYearViewSec()
        {
            List<Section> listSec =  firstYearService.ViewSection();
            return View(listSec);
        }

        public ActionResult FirstYearAddSec()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FirstYearAddSec(Section sec)
        {
            adminService.AddSection(sec);
            return View();
        }





        [HttpPost]
        public ActionResult FirstYearView(Subject sub)
        {
            firstYearService.AddSubject(sub);
            return View();
        }

        //[HttpGet]
        //public ActionResult FirstYearView(Subject sub)
        //{
        //    firstYearService.AddSubject(sub);
        //    return View();
        //}


    }
}