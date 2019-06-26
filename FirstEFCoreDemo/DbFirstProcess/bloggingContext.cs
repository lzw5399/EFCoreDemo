using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstEFCoreDemo.DbFirstProcess
{
    public partial class bloggingContext : DbContext
    {
        public bloggingContext()
        {
        }

        public bloggingContext(DbContextOptions<bloggingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blogs> Blogs { get; set; }

        public virtual DbSet<Posts> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=47.100.220.174;Database=blogging;User Id=root;Password=LZWxm!@#123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Blogs>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("Blogs", "blogging");

                entity.Property(e => e.BlogId).HasColumnType("int(11)");

                entity.Property(e => e.Url).IsUnicode(false);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId);

                entity.ToTable("Posts", "blogging");

                entity.HasIndex(e => e.BlogId);

                entity.Property(e => e.PostId).HasColumnType("int(11)");

                entity.Property(e => e.BlogId).HasColumnType("int(11)");

                entity.Property(e => e.Content).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasDefaultValueSql("0001-01-01 00:00:00");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.BlogId);
            });
        }
    }
}