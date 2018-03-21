using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedW.Model.User;

namespace RedW.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly MyDbContext _context;
        public UserController(MyDbContext context)
        {
            _context = context;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<Userinfo> Get()
        {
            return _context.Users.Skip(10).Take(10).AsEnumerable();
            //return _context.Users.AsEnumerable();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<Userinfo> Get(int id)
        {
            return await _context.Users.FindAsync(id);
        }
        
        // POST: api/User
        [HttpPost]
        public async Task Post([FromBody]IEnumerable<Userinfo> o)
        {
            await _context.Users.AddRangeAsync(o);
            await _context.SaveChangesAsync();
        }
        // PUT: api/User
        [HttpPut]
        public async Task Put(Userinfo o)
        {
            var entity = _context.Users.Find(o.Id);
            var d = o.GetType().GetProperties().Where(n => n.GetValue(o, null) != null);
            foreach (var item in d)
            {
                entity.GetType().GetProperties().Where(n => n.PropertyType.Equals(item.PropertyType));
            }
            entity.Username = o.Username;
            _context.Users.Update(o);
            await _context.SaveChangesAsync();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var entity = _context.Users.Find(id);
            _context.Users.Remove(entity);
            //_context.Users.Remove(o);
            await _context.SaveChangesAsync();
        }
    }
}
