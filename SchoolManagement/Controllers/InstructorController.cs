using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    public class InstructorController : Controller
    {
        // GET: Instructor
        public ActionResult Instructors()
        {
            var db = new SchoolEntities();
            var ins = from i in db.CourseInstructors
                      where i.CourseID == new int()
                      select i;
            return View(db.CourseInstructors.ToList());

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CourseInstructor newinstructor)
        {

            if (ModelState.IsValid)
            {
                var db = new SchoolEntities();
                db.CourseInstructors.Add(newinstructor);
                db.SaveChanges();

                return RedirectToAction("Instructors");
            }
            else
            {
                return View(newinstructor);
            }
        }
    }
}