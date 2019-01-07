using PublicSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Database
{
    public class PublicSchoolDBContext : DbContext
    {
        public PublicSchoolDBContext(): base("PublicSchoolDb")
        {
            System.Data.Entity.Database.SetInitializer<PublicSchoolDBContext>(new DropCreateDatabaseAlways<PublicSchoolDBContext>());
        }
        public DbSet<Student> Students { get; set; }
    }
}
