﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name ="List Price")]
        [Range(1,1000)]
        public double ListPrice;

        [Required]
        [Display(Name = "Price 1-50")]
        [Range(1, 1000)]
        public double Price;

        [Required]
        [Display(Name = "Price 50+")]
        [Range(1, 1000)]
        public double Price50;

        [Required]
        [Display(Name = "Price100+")]
        [Range(1, 1000)]
        public double Price100;

    }
}
