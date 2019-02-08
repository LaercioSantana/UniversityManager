using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityManager.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}