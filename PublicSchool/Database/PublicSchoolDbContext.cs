using Microsoft.EntityFrameworkCore;
using PublicSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Database
{
    public class PublicSchoolDbContext : DbContext
    {
        public PublicSchoolDbContext(DbContextOptions<PublicSchoolDbContext> options)
        : base(options)
        {
           
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }


    }
}
