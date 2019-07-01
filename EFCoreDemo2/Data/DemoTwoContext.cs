using EFCoreDemo.Model.Converter;
using EFCoreDemo2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

        public DbSet<Book> Books { get; set; }

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

            // 最原始的值转换配置
            //modelBuilder
            //    .Entity<Book>()
            //    .Property(b => b.Type)
            //    .HasConversion(
            //        s => s.ToString(),
            //        g => (BookType)Enum.Parse(typeof(BookType), g)
            //    );

            // 使用ValueConverter类的值转换器
            //var converter1 = new ValueConverter<BookType, string>(
            //        s => s.ToString(),
            //        g => (BookType)Enum.Parse(typeof(BookType), g);

            //modelBuilder
            //    .Entity<Book>()
            //    .Property(b => b.Type)
            //    .HasConversion(converter1);

            //// 使用内置的值转换器类进行转换
            //var converter2 = new EnumToStringConverter<BookType>();
            //modelBuilder
            //    .Entity<Book>()
            //    .Property(b => b.Type)
            //    .HasConversion(converter2);

            // 使用预定义的转换
            modelBuilder
                .Entity<Book>()
                .Property(b => b.Type)
                .HasConversion<string>();

            modelBuilder
                .Entity<Book>()
                .HasData(new Book { Id = 7, Name = "233", Type = BookType.Science }, new { Id = 6, Name = "测试匿名类", Type = BookType.Classic });
        }
    }
}