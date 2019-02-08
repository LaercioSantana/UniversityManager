using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManager.Models;

namespace UniversityManager.ViewModels
{
    public class SelectTeacherViewModel
    {
        public ICollection<Teacher> Teachers;
        public int SelectedTeacherID;

    }
}