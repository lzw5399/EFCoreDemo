using EFCoreDemo.Model.QueryResult;
using EFCoreDemo.Model.Xulie;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo3.Data
{
    public class DemoThreeContext : DbContext
    {
        public DbSet<Sequencess> Sequencesses { get; set; }

        public DbSet<EFCoreDemo.Model.QueryResult.Blog> Blogs { get; set; }

        public DbSet<EFCoreDemo.Model.QueryResult.Post> Posts { get; set; }

        public DemoThreeContext(DbContextOptions<DemoThreeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 序列配置，Mysql不支持
            //modelBuilder
            //    .HasSequence<int>("sequ")
            //    .StartsAt(1000)
            //    .IncrementsBy(5);

            // 新建视图
            //this.Database.ExecuteSqlCommand(
            //    @"CREATE VIEW View_BlogPostCounts AS
            //        SELECT b.Name, Count(p.PostId) as PostCount
            //        FROM Blogs b
            //        JOIN Posts p on p.BlogId = b.BlogId
            ///        GROUP BY b.Name");

            // 查询类型的配置
            modelBuilder
                .Query<BlogPostsCount>().ToView("View_BlogPostCounts")
                .Property(v => v.BlogName).HasColumnName("Name");
        }
    }
}