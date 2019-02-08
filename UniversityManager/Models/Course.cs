using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManager.Models
{
    public class Course
    {
        public int ID { set; get; }
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}