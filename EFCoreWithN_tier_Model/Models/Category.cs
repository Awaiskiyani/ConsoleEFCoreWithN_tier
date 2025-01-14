﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    [Table("Categories")]
    public class Category
    {
        public int CategoryId { get; set; }
        [Column("Name")]
        [Required]
        public int CategoryName { get; set; }
        //public int DisplayOrder { get; set; }
    }
}
