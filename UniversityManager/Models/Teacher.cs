using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManager.Models
{
    public class Teacher : Person
    {
        public decimal Remuneration { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}