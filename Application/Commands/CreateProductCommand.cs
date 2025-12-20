using Application.DTOs;
using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateProductCommand
    {

        private readonly IProductRepoistery _repo;
        public CreateProductCommand(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public async Task<bool> Excute(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };
            _repo.AddProduct(product);
            _repo.SaveChanges();
            return true;
        }

    }
}
