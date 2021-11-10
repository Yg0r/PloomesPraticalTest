using System;
using System.ComponentModel.DataAnnotations;

namespace PloomesPraticalTest.Src.Models
{
    public class Drug
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public Decimal Price { get; set; }

        public Boolean IsGeneric { get; set; }
    }
}
