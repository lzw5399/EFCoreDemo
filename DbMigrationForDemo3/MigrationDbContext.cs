using EFCoreDemo3.Data;
using Microsoft.EntityFrameworkCore;

namespace DbMigrationForDemo3
{
    public class MigrationDbContext : DemoThreeContext
    {
        public MigrationDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}