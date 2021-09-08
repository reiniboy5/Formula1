using Formula1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formula1.Data
{
    public class Formula1DbContext : DbContext
    {
        public Formula1DbContext(DbContextOptions<Formula1DbContext> options) : base(options)
        {

        }

        public DbSet<Teams> Teams { get; set; }
        public DbSet<Drivers> Drivers { get; set; }
    }
}
