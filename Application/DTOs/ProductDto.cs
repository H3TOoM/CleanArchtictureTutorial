using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class ProductDto
    {
        public string Name {  get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
