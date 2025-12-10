using Domain.Entites;
using Domain.Repoistiers;
using Infrastucture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infrastucture.Reposities
{
    internal class ProductRepoistry : IProductRepoistery
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Product> _dbSet;

        public ProductRepoistry(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Product>();

        }

        public void AddProduct(Product product)
        {
            _dbSet.Add(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts() => _dbSet.ToList();
        
           
        
    }
}
