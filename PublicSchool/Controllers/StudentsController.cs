using Microsoft.AspNetCore.Mvc;
using PublicSchool.Database;
using PublicSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicSchool.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StudentsController : Controller
    {
        public PublicSchoolDbContext _ctx { get; set; }

        public StudentsController(PublicSchoolDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Student> List()
        {
            var query =  _ctx.Students.ToList();
            return query;
        }


        [Route("{id:int}")]
        [Produces("application/json")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            var query = await _ctx.Students.FindAsync(id);
            return Ok(query);
        }
    }
}
