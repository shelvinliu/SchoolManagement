using SchoolManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
        public ActionResult CourseManagement()
        {
            var entities = new SchoolEntities();
            return View(entities.Courses.ToList());
        }
       
        public ActionResult Login()
        {
            ViewBag.Message = "Login Page";
            return View();
        }
        //public ActionResult StudentGradeManagement()
       // {
           // var entities = new SchoolEntities();
            //return View(entities.StudentGrades.ToList());
      //  }
        
      
        }
    }