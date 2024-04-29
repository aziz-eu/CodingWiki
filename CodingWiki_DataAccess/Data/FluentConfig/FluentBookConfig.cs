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
    public class FluentBookConfig : IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder <Fluent_Book> modelBuilder)
        {
            modelBuilder.HasKey(u => u.Id);
            modelBuilder.Ignore(u => u.PriceRange);
            modelBuilder.Property(u => u.ISBN).HasMaxLength(20);
            modelBuilder.HasOne(b => b.Publisher).WithMany(b => b.Books)
                .HasForeignKey(u => u.Publisher_Id);
        }
    }
}
