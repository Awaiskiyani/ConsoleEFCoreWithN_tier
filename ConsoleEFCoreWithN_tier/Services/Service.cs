using ConsoleEfCoreWithN_tier_DataAccess.Data;
using EFCoreWithN_tier_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFCoreWithN_tier.Services
{
    public class Service
    {
       public  void GetAllBooks()
        {
            Console.WriteLine("GetAllBooks");

            var context = new ApplicationDBContext();
            var books = context.Books.ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Id + " " + item.Title);
            }
            
        }

      public   void GetBookFirstOrDefault()
        {
            Console.WriteLine("Get Books using FistOrDefault Method");
            var context = new ApplicationDBContext();
            var books = context.Books.FirstOrDefault();
            Console.WriteLine(books.Title);
        }

       public void GetBookByPublisher()
        {
            Console.WriteLine("Get Book by Publisher:");
            var context = new ApplicationDBContext();
            var books = context.Books.Where(u => u.Publisher_Id == 1).FirstOrDefault();
            Console.WriteLine(books.Title);
        }


     public   void GetBookBySeededID()
        {
            Console.WriteLine("Get Book By Id");
            var context = new ApplicationDBContext();
            var books = context.Books.Find(1);
            Console.WriteLine(books.Title);
        }

     public   void GetBookByPubliserIdseededUsingSingle()
        {
            Console.WriteLine("Get Book using Single");
            var context = new ApplicationDBContext();
            var books = context.Books.First(u => u.Publisher_Id == 1);
            Console.WriteLine(books.Title);
        }

     public   void AddBooks()
        {
            Console.WriteLine("Adding a Book seeding Data");
           

            Book addbook = new Book() { Title = "MyBook", ISBN = "23452", price = 676, Publisher_Id = 1 };
            var context = new ApplicationDBContext();
            var books = context.Books.Add(addbook);
            context.SaveChanges();
            Console.WriteLine("Book Added Successfullyy");

        }

       public void SortBookUsingOrderBy()
        {
            Console.WriteLine("Sorting Books using orderBy");
            var context = new ApplicationDBContext();
            var books = context.Books.OrderBy(u => u.Title).ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }
        }

      public  void sortBookUsingOrderByDescending()
        {
            Console.WriteLine("Sorting Book using orderByDecending");
            var context = new ApplicationDBContext();
            var books = context.Books.OrderByDescending(u => u.Title).ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item.Title);
            }
        }

       
    }
}
