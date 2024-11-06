using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using libreria_JAGS.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace libreria_JAGS.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
    }
}
