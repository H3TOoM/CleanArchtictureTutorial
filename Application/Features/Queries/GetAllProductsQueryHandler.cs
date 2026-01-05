using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Queries
{
    public class GetAllProductsQueryHandler
    {
        private readonly IProductRepoistery _repo;
        public GetAllProductsQueryHandler(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> Handle(GetAllProductsQuery query)
        {
            return _repo.GetAllProducts();
        }
    }
}
