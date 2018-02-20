using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataObjects;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class BuildController : Controller
    {
        private readonly BuildContext _buildContext;

        public BuildController(BuildContext context)
        {
            _buildContext = context ?? throw new ArgumentNullException(nameof(context));
            
            ((DbContext)context).ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var items = await _buildContext.
            //    .ToListAsync();
            List<string> lst = new List<string>() { "A" };
            return lst;
            //return Ok(lst);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]BuildItem value)
        {
            var build = new BuildItem
            {
                Id = 2,
                Name = "test",
                Description = "testin 123"
            };
            _buildContext.BuildItems.Add(build);

            return Json(value);            //await _buildContext.Sav
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
