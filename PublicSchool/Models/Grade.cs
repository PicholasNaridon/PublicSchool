using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public double NumGrade { get; set; }
        public Assignment MyProperty { get; set; }
        public Student Student { get; set; }
    }
}
