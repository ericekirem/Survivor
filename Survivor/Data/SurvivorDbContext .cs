using Microsoft.EntityFrameworkCore;
using Survivor.Entitiy;
using System.Collections.Generic;

namespace Survivor.Data
{
    public class SurvivorDbContext : DbContext
    {
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options)
            : base(options)
        { }
    }

}
