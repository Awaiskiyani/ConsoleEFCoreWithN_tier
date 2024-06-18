﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWithN_tier_Model.Models
{
    public class BookDetails
    {
        [Key]
        public int BookDetail_Id { get; set; }

        [Required]
        public int NumberofChapters { get; set; }
        public int NumberofPages { get; set; }
        public string Weight { get; set; }
        [ForeignKey("Book")]
        public int Book_Id { get; set; }
        public Book Book { get; set; }
    }
}
