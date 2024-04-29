using CodingWiki_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data.FluentConfig
{
    public class FluentBookDetailConfig : IEntityTypeConfiguration<Fluent_Book_Detail>
    {
        public void Configure(EntityTypeBuilder <Fluent_Book_Detail> modelBuilder)
        {
            modelBuilder.ToTable("Fluent_Details");
            modelBuilder.Property(u => u.NumberOfCapter).HasColumnName("TotalCapter");
            modelBuilder.Property(u => u.NumberOfCapter).IsRequired();
            modelBuilder.HasKey(u => u.BookDetail_Id);
            modelBuilder.HasOne(b => b.Book).WithOne(b => b.BookDetail)
                .HasForeignKey<Fluent_Book_Detail>(u => u.Book_Id);
        }
    }
}
