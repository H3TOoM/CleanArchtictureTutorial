using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class AddProductCommandHandler
    {
        private readonly IProductRepoistery _repo;
        public AddProductCommandHandler(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(AddProductCommand command)
        {
            if (command == null || command.Product == null)
                return false;

            var product = new Product
            {
                Name = command.Product.Name,
                Price = command.Product.Price,
            };

            _repo.AddProduct(product);
            _repo.SaveChanges();

            return true;
        }
    }
}
