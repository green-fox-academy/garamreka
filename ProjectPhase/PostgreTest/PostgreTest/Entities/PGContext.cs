using Microsoft.EntityFrameworkCore;
using PostgreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreTest.Entities
{
    public class PGContext : DbContext
    {
        public PGContext(DbContextOptions<PGContext> options) : base(options)
        {

        }

        public DbSet<PG> PGs { get; set; }
    }
}
