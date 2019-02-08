using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityManager.Models
{
    public class Student : Person
    {
        public int CourseID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}