using CodingWiki_Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data.FluentConfig
{
    public class FluentBookAutorConfig : IEntityTypeConfiguration<Fluent_BookAuthorMap>
    {
        public void Configure(EntityTypeBuilder <Fluent_BookAuthorMap> modelBuilder) {


            modelBuilder.HasKey(u => new { u.Book_Id, u.Author_Id });
            modelBuilder.HasOne(u => u.Book).WithMany(u => u.BookAuthorMaps).HasForeignKey(u => u.Book_Id);
            modelBuilder.HasOne(u => u.Author).WithMany(u => u.BookAuthorMaps).HasForeignKey(u => u.Author_Id);


        }
    }
}
