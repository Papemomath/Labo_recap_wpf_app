using IdeaManager.Data.Db;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace IdeaManager.Data.DB
{
    public class IdeaDbContextFactory : IDesignTimeDbContextFactory<IdeaDbContext>
    {
        public IdeaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IdeaDbContext>();
            optionsBuilder.UseSqlite("Data Source=idea.db");

            return new IdeaDbContext(optionsBuilder.Options);
        }
    }
}
