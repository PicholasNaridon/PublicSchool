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
    public class TeachersController : Controller
    {
        public PublicSchoolDbContext _ctx { get; set; }
        public TeachersController(PublicSchoolDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Teacher> List()
        {
            var query = _ctx.Teachers.ToList();
            return query;
        }

        [Route("{id:int}")]
        [Produces("application/json")]
        public async Task<ActionResult<Teacher>> Get(int id)
        {
            var query = await _ctx.Teachers.FindAsync(id);
            return Ok(query);
        }
    }
}
