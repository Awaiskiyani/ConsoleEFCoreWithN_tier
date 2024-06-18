using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        
        [MaxLength(20)]
        [Required]
        public string ISBN { get; set; }
        public decimal price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }

        public BookDetails BookDetails { get; set; }
        public  List<BookAuthorMap> BookAuthorMap { get; set; }


    }
}
