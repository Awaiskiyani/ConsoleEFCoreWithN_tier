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
    public class FluentAuthorConfig:IEntityTypeConfiguration<FluentAuthor>
    {
        public void Configure(EntityTypeBuilder<FluentAuthor> modelBuilder)
        {

            modelBuilder.Property(u => u.FirstName).HasMaxLength(50);
            modelBuilder.Property(u => u.FirstName).IsRequired();
            modelBuilder.Property(u => u.LastName).IsRequired();
            modelBuilder.HasKey(u => u.Author_Id);
            modelBuilder.Ignore(i => i.FirstName);
        }
    }
}
