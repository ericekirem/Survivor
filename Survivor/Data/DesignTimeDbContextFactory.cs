using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Survivor.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SurvivorDbContext>
    {
        public SurvivorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SurvivorDbContext>();
            optionsBuilder.UseSqlite("Data Source=SurvivorDb1.db"); // Bağlantı dizesini buraya ekleyin

            return new SurvivorDbContext(optionsBuilder.Options);
        }
    }
}
