using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace Domain.Repoistiers
{
    public interface IProductRepoistery
    {
        List<Product> GetAllProducts();
        void AddProduct(Product product);
        
    }
}
