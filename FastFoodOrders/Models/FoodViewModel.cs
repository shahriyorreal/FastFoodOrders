﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FastFoodOrders.Models
{
    public class FoodViewModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Food Name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [DisplayName("Composition food")]
        [MaxLength(150)]
        public string Compositions { get; set; }
        [Required]
        [DisplayName("Price Food")]
        [MaxLength(20)]
        public string Price { get; set; }
        public string PhotoFilePath { get; set; }
    }
}
