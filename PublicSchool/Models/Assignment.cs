using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Models
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public Course Course { get; set; }
        public Grade Grade { get; set; }
        public AssignmentType AssignmentType { get; set; }
        public bool Submitted { get; set; }
    }
}
