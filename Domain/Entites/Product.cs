using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        // Navigation property to Category

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
