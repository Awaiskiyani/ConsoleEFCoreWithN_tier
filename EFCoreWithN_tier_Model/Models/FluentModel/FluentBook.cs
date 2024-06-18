using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    public class FluentBook
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string ISBN { get; set; }
        public decimal price { get; set; }
        
        public string PriceRange { get; set; }
        
        public int Publisher_Id { get; set; }
        public FluentPublisher Publisher { get; set; }

       // public List<FluentAuthor> Authors { get; set; }
        public FluentBookDetails BookDetails { get; set; }
        public  List<FluentBookAuthorMap> BookAuthorMap { get; set; }


    }
}
