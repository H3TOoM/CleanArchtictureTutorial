using Application.DTOs;
using Application.Interfaces;
using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepoistery _repo;
        public ProductService(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public bool AddProduct(Product product)
        {
            if (product == null)
                return false;
            _repo.AddProduct(product);
            return true;
        }

        public List<ProductDto> GetAllProducts()
        {
            var products = _repo.GetAllProducts();
            var productsList = new List<ProductDto>();
            foreach (var product in products)
            {
                var productDto = new ProductDto
                {
                    Name = product.Name,
                    Price = product.Price,
                };
                productsList.Add(productDto);
            }

            return productsList;

        }
    }
}
