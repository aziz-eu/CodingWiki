using CodingWiki_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet <Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Book_Detail> Book_Details { get; set; }



        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-B04RPVN4\\SQLEXPRESS;Database=CodingWiki;Trusted_Connection=True;TrustServerCertificate=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(18, 5);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Price = 100.30m, ISBN = "12345" , Title = "New Book1 " },
                new Book { Id = 2, Price = 10.30m, ISBN = "12342389285", Title = "New Book2 " }
            );
        }
    }
}
