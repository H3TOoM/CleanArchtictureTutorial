using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entites;

namespace Domain.Repoistiers
{
    public interface IProductRepoistery
    {
        Task<List<Product>> GetAllProducts();
        void AddProduct(Product product);
        void SaveChanges();
    }
}
