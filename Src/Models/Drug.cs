using System;

namespace PloomesPraticalTest.Src.Models
{
    public class Drug
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public Boolean IsGeneric { get; set; }
    }
}
