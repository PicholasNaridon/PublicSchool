using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Models
{
    public class Course
    {
       
        public int CourseId { get; set; }
        public Teacher TeacherId { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
    }
}
