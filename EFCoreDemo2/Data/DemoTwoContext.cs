using EFCoreDemo2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo2.Data
{
    public class BloggingContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Email> Emails { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 表拆分
            modelBuilder
                .Entity<OrderAddress>()
                .ToTable("Orders");

            modelBuilder
                .Entity<Order>()
                .ToTable("Orders")
                .HasOne(o => o.OrderAddress)
                .WithOne()
                .HasForeignKey<Order>(o => o.Id);

            // 固有实体属性
            modelBuilder
                .Entity<Email>()
                .OwnsOne(e => e.EmailContent);

            // 私有字段配置
            modelBuilder
                .Entity<Email>()
                .Property(it => it.Test)
                .HasField("_test");
        }
    }
}
