using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Courses()
        {
            var db = new SchoolEntities();
            return View(db.Courses.ToList());
        }
        public ActionResult Create()
        { 
                return View();
            }
           
        }
    }
