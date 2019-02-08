﻿using System;
using System.Collections.Generic;
using UniversityManager.Models;

namespace UniversityManager.DAL
{
    public class SchoolInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{Name="Carson Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"), Birthday=DateTime.Parse("1995-09-01")},
            new Student{Name="Meredith Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"), Birthday=DateTime.Parse("1995-08-01")},
            new Student{Name="Arturo Anand",EnrollmentDate=DateTime.Parse("2003-09-01"), Birthday=DateTime.Parse("1995-05-01")},
            new Student{Name="Gytis Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"), Birthday=DateTime.Parse("1993-09-01")},
            new Student{Name="Yan Li",EnrollmentDate=DateTime.Parse("2002-09-01"), Birthday=DateTime.Parse("1992-09-01")},
            new Student{Name="Peggy Justice",EnrollmentDate=DateTime.Parse("2001-09-01"), Birthday=DateTime.Parse("1999-09-07")},
            new Student{Name="Laura Norman",EnrollmentDate=DateTime.Parse("2003-09-01"), Birthday=DateTime.Parse("1991-03-01")},
            new Student{Name="Nino Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"), Birthday=DateTime.Parse("1992-03-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var subjects = new List<Subject>
            {
            new Subject{SubjectID=1050,Title="Chemistry",Credits=3,},
            new Subject{SubjectID=4022,Title="Microeconomics",Credits=3,},
            new Subject{SubjectID=4041,Title="Macroeconomics",Credits=3,},
            new Subject{SubjectID=1045,Title="Calculus",Credits=4,},
            new Subject{SubjectID=3141,Title="Trigonometry",Credits=4,},
            new Subject{SubjectID=2021,Title="Composition",Credits=3,},
            new Subject{SubjectID=2042,Title="Literature",Credits=4,}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,SubjectID=1050,Grade=10},
            new Enrollment{StudentID=1,SubjectID=4022,Grade=7},
            new Enrollment{StudentID=1,SubjectID=4041,Grade=8},
            new Enrollment{StudentID=2,SubjectID=1045,Grade=8},
            new Enrollment{StudentID=2,SubjectID=3141,Grade=2},
            new Enrollment{StudentID=2,SubjectID=2021,Grade=1},
            new Enrollment{StudentID=3,SubjectID=1050},
            new Enrollment{StudentID=4,SubjectID=1050,},
            new Enrollment{StudentID=4,SubjectID=4022,Grade=3},
            new Enrollment{StudentID=5,SubjectID=4041,Grade=5},
            new Enrollment{StudentID=6,SubjectID=1045},
            new Enrollment{StudentID=7,SubjectID=3141,Grade=10},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}