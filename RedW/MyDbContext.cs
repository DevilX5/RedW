using Microsoft.EntityFrameworkCore;
using RedW.Model.Product;
using RedW.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedW
{
    public class MyDbContext:DbContext
    {
        public DbSet<TestTable> TestTables { get; set; }
        public DbSet<Userinfo> Users { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }
    }
}
