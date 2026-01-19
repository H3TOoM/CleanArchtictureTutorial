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

        public List<Product> GetAllProducts() => _context.products.AsNoTracking().ToList();

        // AsNoTracking() improves performance when entities are only read and not updated.
        // Queries = AsNoTracking() is particularly useful in read-only scenarios, such as displaying data in a web application,
        // Commands = Tracking() is essential for scenarios where data modifications are required.

        public void SaveChanges()
        {
            _context.SaveChanges();
            // Dif Between SaveChanges and SaveChangesAsync
            // SaveChanges is a synchronous method that blocks the calling
            // thread until the operation is complete, while SaveChangesAsync is asynchronous
            // and allows the calling thread to continue executing other code,recommended for web applications.
        }

    }
}
