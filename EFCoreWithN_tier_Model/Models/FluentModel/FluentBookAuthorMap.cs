using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    public class FluentBookAuthorMap
    {
      //  [ForeignKey("Book")]
        public int BoodId { get; set; }
       // [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public FluentBook Book { get; set; }
        public FluentAuthor Author { get; set; }
    }
}
