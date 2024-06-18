using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    public class FluentAuthor
    {
        
        public int Author_Id { get; set; }
      
        public string FirstName { get; set; }
  
        public int LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Location { get; set; }
     
        public string FullName
        { 
            get
            { 
                return $"{FirstName} {LastName}";
            } 
        }
       // public List<FluentBook> MyProperty { get; set; }
        public List<FluentBookAuthorMap> Books { get; set; }

    }
}
