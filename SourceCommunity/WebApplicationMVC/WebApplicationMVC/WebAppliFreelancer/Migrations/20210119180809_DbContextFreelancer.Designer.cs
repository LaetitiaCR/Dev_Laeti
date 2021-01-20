﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppliFreelancer.Data;

namespace WebAppliFreelancer.Migrations
{
    [DbContext(typeof(FreelancerDbContext))]
    [Migration("20210119180809_DbContextFreelancer")]
    partial class DbContextFreelancer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("WebAppliFreelancer.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id")
                        .UseIdentityColumn();

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("CustomercatId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebAppliFreelancer.Models.Customercat", b =>
                {
                    b.Property<int>("CustomercatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customercat_id")
                        .UseIdentityColumn();

                    b.Property<string>("CustomercatDescription")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomercatName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomercatId");

                    b.ToTable("Customercats");
                });

            modelBuilder.Entity("WebAppliFreelancer.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("job_id")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("JobDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("JobEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("JobStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobState")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("JobId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("WebAppliFreelancer.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("quote_id")
                        .UseIdentityColumn();

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("QuoteAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuoteFinalAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("QuoteFinalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuoteState")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}
