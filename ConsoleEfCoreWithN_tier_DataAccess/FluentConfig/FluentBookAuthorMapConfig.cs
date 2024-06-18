using EFCoreWithN_tier_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEfCoreWithN_tier_DataAccess.FluentConfig
{
    public class FluentBookAuthorMapConfig:IEntityTypeConfiguration<FluentBookAuthorMap>
    {
        public void Configure(EntityTypeBuilder<FluentBookAuthorMap> modelBuilder)
        {

      

            modelBuilder.HasKey(u => new { u.AuthorId, u.BoodId });
            modelBuilder.HasOne(u => u.Book).WithMany(u => u.BookAuthorMap)
                .HasForeignKey(u => u.BoodId);
            modelBuilder.HasOne(u => u.Author).WithMany(u => u.Books)
                .HasForeignKey(u => u.AuthorId);
        }
    }
}
