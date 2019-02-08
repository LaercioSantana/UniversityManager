using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManager.Models;

namespace UniversityManager.ViewModels
{
    public class SelectCourseViewModel
    {
        public ICollection<Course> Courses;
        public int? SelectedCourseID;
    }
}