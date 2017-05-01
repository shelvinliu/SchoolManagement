using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Models
{
    public class Tables
    {
        public Person student { get; set; } 
        public StudentGrade grade { get; set; }
        public Course course { get; set;}
    }
}