using Domain.Entites;
using Domain.Repoistiers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Commands
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand>
    {
        private readonly IProductRepoistery _repo;
        public AddProductCommandHandler(IProductRepoistery repo)
        {
            _repo = repo;
        }

        //public async Task<bool> Handle(AddProductCommand command)
        //{
        //    if (command == null || command.Product == null)
        //        return false;

        //    var product = new Product
        //    {
        //        Name = command.Product.Name,
        //        Price = command.Product.Price,
        //    };

        //    _repo.AddProduct(product);
        //    _repo.SaveChanges();

        //    return true;
        //} Without MediatR

        public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Product.Name,
                Price = request.Product.Price,
            };
            _repo.AddProduct(product);
            _repo.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
