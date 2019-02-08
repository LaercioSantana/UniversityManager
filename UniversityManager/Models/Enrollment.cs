using System.ComponentModel.DataAnnotations;

namespace UniversityManager.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int SubjectID { get; set; }
        public int StudentID { get; set; }
        [Range(1, 10)]
        public int? Grade { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
    }
}