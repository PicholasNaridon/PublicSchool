using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Year Year { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public Parent Parent { get; set; }
    }
}
