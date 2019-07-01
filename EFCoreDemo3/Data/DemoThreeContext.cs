using EFCoreDemo.Model.Xulie;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo3.Data
{
    public class DemoThreeContext : DbContext
    {
        public DbSet<Sequencess> Sequencesses { get; set; }

        public DemoThreeContext(DbContextOptions<DemoThreeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasSequence<int>("OrderNumbers")
                .StartsAt(1000)
                .IncrementsBy(5);
        }
    }
}
