using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PublicSchool.Database;
using PublicSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EnrollmentsController : Controller
    {
        private readonly PublicSchoolDbContext _ctx;

        public EnrollmentsController(PublicSchoolDbContext ctx)
        {
            _ctx = ctx;
        }

        [Produces("application/json")]
        public IEnumerable<Enrollment> List()
        {
            var query = _ctx.Enrollments
                .Include(e => e.Student)
                .ToList();

            return query;
        }
    }
}
