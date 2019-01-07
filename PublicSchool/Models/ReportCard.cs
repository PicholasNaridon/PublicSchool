using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Models
{
    public class ReportCard
    {
        public int ReportCardId { get; set; }
        public Student Student { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
