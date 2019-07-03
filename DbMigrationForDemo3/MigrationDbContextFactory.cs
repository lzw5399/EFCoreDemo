using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DbMigrationForDemo3
{
    public class MigrationDbContextFactory : IDesignTimeDbContextFactory<MigrationDbContext>
    {
        public MigrationDbContext CreateDbContext(string[] args)
        {
            var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true);
            var configuration = configBuilder.Build();
            var connectionString = configuration.GetConnectionString("aliyun_mysql");
            var optionsBuilder = new DbContextOptionsBuilder<MigrationDbContext>();
            optionsBuilder.UseMySQL(connectionString, opts => opts.MigrationsHistoryTable("_MigrationHistory"));

            return new MigrationDbContext(optionsBuilder.Options);
        }
    }
}