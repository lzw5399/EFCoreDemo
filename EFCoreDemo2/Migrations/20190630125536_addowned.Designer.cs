﻿// <auto-generated />
using EFCoreDemo2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreDemo2.Migrations
{
    [DbContext(typeof(BloggingContext))]
    [Migration("20190630125536_addowned")]
    partial class addowned
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("EFCoreDemo2.Models.Order", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCoreDemo2.Models.OrderAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingAddress");

                    b.Property<string>("ShippingAddress");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EFCoreDemo2.Models.Order", b =>
                {
                    b.HasOne("EFCoreDemo2.Models.OrderAddress", "OrderAddress")
                        .WithOne()
                        .HasForeignKey("EFCoreDemo2.Models.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
