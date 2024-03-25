using System;

namespace WebApplicationn8.Models
{
    public class Product
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; } = decimal.Zero;
        public DateTime CreatedDate { get; set; } = DateTime.MinValue;
    }
}
