﻿// <auto-generated />
using System;
using CodingWiki_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodingWiki_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429060406_addFluentBookDetailsTbl")]
    partial class addFluentBookDetailsTbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodingWiki_Models.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Author_Id"), 1L, 1);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ISBN")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 5)
                        .HasColumnType("decimal(18,5)");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ISBN = "12345",
                            Price = 100.30m,
                            Publisher_Id = 1,
                            Title = "New Book1 "
                        },
                        new
                        {
                            Id = 2,
                            ISBN = "12342389285",
                            Price = 10.30m,
                            Publisher_Id = 1,
                            Title = "New Book2 "
                        });
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book_Detail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"), 1L, 1);

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfCapter")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.HasIndex("Book_Id")
                        .IsUnique();

                    b.ToTable("book_Details");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.BookAuthorMap", b =>
                {
                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Author_Id1")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.HasKey("Book_Id", "Author_Id");

                    b.HasIndex("Author_Id1");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthorMap");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Category_Name");

                    b.HasKey("Category_Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Fluent_Book_Detail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetail_Id"), 1L, 1);

                    b.Property<int>("NumberOfCapter")
                        .HasColumnType("int")
                        .HasColumnName("TotalCapter");

                    b.Property<int>("NumberOfPage")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("Fluent_Details", (string)null);
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Publisher_Id"), 1L, 1);

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Publisher_Id = 1,
                            Location = "Dhaka",
                            Name = "Prio"
                        });
                });

            modelBuilder.Entity("CodingWiki_Models.Models.SubCategory", b =>
                {
                    b.Property<int>("SubCategory_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubCategory_Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SubCategory_Id");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book_Detail", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("CodingWiki_Models.Models.Book_Detail", "Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.BookAuthorMap", b =>
                {
                    b.HasOne("CodingWiki_Models.Models.Author", "Author")
                        .WithMany("bookAuthorMaps")
                        .HasForeignKey("Author_Id1");

                    b.HasOne("CodingWiki_Models.Models.Book", "Book")
                        .WithMany("BookAuthorMaps")
                        .HasForeignKey("BookId");

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Author", b =>
                {
                    b.Navigation("bookAuthorMaps");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Book", b =>
                {
                    b.Navigation("BookAuthorMaps");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("CodingWiki_Models.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
