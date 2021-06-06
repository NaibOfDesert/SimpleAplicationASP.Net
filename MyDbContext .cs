using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAplicationASP.Net
{
    public class MyDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
