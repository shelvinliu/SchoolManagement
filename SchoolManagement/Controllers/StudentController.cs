using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement.Controllers
{
    
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentProfile()
        {
            var db = new SchoolEntities();
            var i = from p in db.People
                    join sg in db.StudentGrades
                    on p.PersonID equals sg.StudentID
                    join c in db.Courses
                    on sg.CourseID equals c.CourseID
                    select new Tables { student= p,grade=sg,course= c };
            return View(i);
        }
        public ActionResult StudentManagement(DateTime? empty)
        {
            var db = new SchoolEntities();
            var showst = db.People.Where(st => st.HireDate == empty);
            return View(showst);
        }
        public ActionResult StudentGradeManagement()
        {
            var db = new SchoolEntities();
            var mysg = from p in db.People
                       join sgd in db.StudentGrades on p.PersonID equals sgd.StudentID
                       select new sg { students = p, grades = sgd };
            return View(mysg);
        }
            public ActionResult Edit(int? id)
        {
            var db = new SchoolEntities();
            Person people = db.People.Find(id);
            if (people == null)
            {
                return HttpNotFound();
            }
            return View(people);
        }

        [HttpPost]
        public ActionResult Edit(Person people)
        {
            var db = new SchoolEntities();
            if (ModelState.IsValid)
            {
                db.Entry(people).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("StudentGradeManagement");
            }
            return View(people);
        }
    }
    }
