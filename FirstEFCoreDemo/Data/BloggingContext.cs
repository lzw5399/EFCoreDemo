using FirstEFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreDemo.Data
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<BlogMetaData> BlogMetaDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Post>()
            //    .Property(b => b.UpdateDate)
            //    .IsRequired(false);

            // 隐藏属性的配置（实体类中没有）
            modelBuilder.Entity<Blog>()
                .Property<bool>("IsDelete");

            // Fluent API配置表关系
            modelBuilder.Entity<Blog>()
                .HasMany(it => it.Posts)
                .WithOne(it => it.Blog);

            // 唯一索引
            modelBuilder.Entity<Blog>()
                .HasIndex(it => it.Url)
                .IsUnique();

            // 组合索引
            modelBuilder.Entity<Blog>()
                .HasIndex(it => new { it.FirstName, it.LastName })
                .IsUnique();

            // 为这两个字段限制最大长度，不然建索引报错
            modelBuilder.Entity<Blog>()
                .Property(it => it.FirstName)
                .HasMaxLength(20);
            modelBuilder.Entity<Blog>()
                .Property(it => it.LastName)
                .HasMaxLength(20);
        }
    }
}
