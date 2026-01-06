using Domain.Entites;
using Domain.Repoistiers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepoistery _repo;
        public GetAllProductsQueryHandler(IProductRepoistery repo)
        {
            _repo = repo;
        }


        // With MediatR
        public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _repo.GetAllProducts();
            return Task.FromResult(products);
        }

        // Without MediatR
        //public IEnumerable<Product> Handle(GetAllProductsQuery query)
        //{
        //    return _repo.GetAllProducts();
        //}
    }
}
