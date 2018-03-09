using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RedW.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly MyDbContext _context;
        public ValuesController(MyDbContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<TestTable> Get()
        {
            return _context.TestTables.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TestTable Get(int id)
        {
            return _context.TestTables.Find(id);
        }

        // POST api/values
        [HttpPost]
        public async Task Post(TestTable o)
        {
            await _context.TestTables.AddAsync(o);
            await _context.SaveChangesAsync();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        //public async Task Put(int id, [FromBody]string value)
        public async Task Put(TestTable o)
        {
            //var entity =await _context.TestTables.FindAsync(id);
            //entity.Name = value;
            //var test = new TestTable() { Id = id, Name = value };
            _context.TestTables.Update(o);
            await _context.SaveChangesAsync();
        }

        // DELETE api/values/5
        //[HttpDelete("{id}")]
        [HttpDelete]
        public async Task Delete(TestTable o)
        {
            //var entity = _context.TestTables.Find(id);
            //_context.TestTables.Remove(entity);
            _context.TestTables.Remove(o);
            await _context.SaveChangesAsync();
        }
    }
}
