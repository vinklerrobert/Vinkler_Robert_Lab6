﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinkler_Robert_Lab6.Models
{
    public class Book
    {
        public int ID { get; set; }
       
        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }
       
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        public DateTime PublishingDate { get; set; }

    }
}
