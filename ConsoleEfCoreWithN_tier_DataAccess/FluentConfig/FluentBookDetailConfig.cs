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
    public class FluentBookDetailConfig:IEntityTypeConfiguration<FluentBookDetails>
    {
        public void Configure(EntityTypeBuilder<FluentBookDetails> modelBuilder)
        {
            //Table Name
            modelBuilder.ToTable("Fluent_BookDetails");

            //Name of Column
            modelBuilder.Property(u => u.NumberofChapters).HasColumnName("NoOfChapters");

            //Primary key
            modelBuilder.HasKey(u => u.BookDetail_Id);

            // Other Validation
            modelBuilder.Property(u => u.NumberofChapters).IsRequired();

            //relation
            modelBuilder.HasOne(b => b.Book).WithOne(b => b.BookDetails)
                .HasForeignKey<FluentBookDetails>(u => u.Book_Id);
        }
    }
}
