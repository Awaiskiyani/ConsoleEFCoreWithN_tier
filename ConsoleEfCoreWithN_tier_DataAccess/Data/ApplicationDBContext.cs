using ConsoleEfCoreWithN_tier_DataAccess.FluentConfig;
using EFCoreWithN_tier_Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEfCoreWithN_tier_DataAccess.Data
{
    public class ApplicationDBContext:DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<BookDetails> BookDetails { get; set; }

        //Fluent table
        public DbSet<FluentBookDetails> BookDetailsfluent { get; set; }
        public DbSet<FluentBook> FluentBook { get; set; }
        public DbSet<FluentAuthor> FluentAuthors { get; set; }
        public DbSet<FluentPublisher> FluentPublishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=MAYAZ\\SQLEXPRESS;Database=NtierAppDB;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           


            modelBuilder.Entity<Book>().Property(u=>u.price).HasPrecision(10,5);
            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.AuthorId, u.BoodId });

            modelBuilder.ApplyConfiguration(new FluentAuthorConfig());
            modelBuilder.ApplyConfiguration(new FluentBookAuthorMapConfig());
            modelBuilder.ApplyConfiguration(new FluentBookConfig());
            modelBuilder.ApplyConfiguration(new FluentBookDetailConfig());
            modelBuilder.ApplyConfiguration(new FluentPublisherConfig());

          


            modelBuilder.Entity<Book>().HasData(
                new Book { Id=1,Title="Spider",ISBN="7675",price=10.99m,Publisher_Id=1},
                new Book { Id = 2, Title = "Hollow", ISBN = "66784", price = 16.99m,Publisher_Id=1 }
                );
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher {Publisher_Id=1, Name="Pub jimmy",Location="Peshawar"},
                  new Publisher { Publisher_Id = 2, Name = "Pub jimmy", Location = "Peshawar" }
                );
        }


    }
}
