using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Commands
{
    public class AddProductCommandHandler
    {
        private readonly IProductRepoistery _repo;
        public AddProductCommandHandler(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public bool Handle(AddProductCommand command)
        {
            if (command == null || command.product == null)
                return false;

            var product = new Product
            {
                Name = command.product.Name,
                Price = command.product.Price,
            };

            _repo.AddProduct(product);
            return true;
        }
    }
}
