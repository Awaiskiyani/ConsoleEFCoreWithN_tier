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
    public class FluentBookConfig:IEntityTypeConfiguration<FluentBook>
    {
        public void Configure(EntityTypeBuilder<FluentBook> modelBuilder)
        {
            modelBuilder.Property(u => u.ISBN).HasMaxLength(50);
            modelBuilder.Property(u => u.ISBN).IsRequired();
            modelBuilder.HasKey(u => u.Id);
            modelBuilder.Ignore(i => i.PriceRange);
            modelBuilder.HasOne(u => u.Publisher).WithMany(u => u.Books)
                .HasForeignKey(u => u.Publisher_Id);
        }
    }
}
