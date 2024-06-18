using ConsoleEfCoreWithN_tier_DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleEfCoreWithN_tier_DataAccess.repo
{
    internal class Book : IBook
    {
        private readonly ApplicationDBContext _dbContext;
       public Book(ApplicationDBContext context)
        {
            _dbContext = context;
        }
        public void GetAllBook()
        {
            var data = _dbContext.Books.ToList();
            foreach (var book in data)
            { 

            }
            
        }
    }
}
