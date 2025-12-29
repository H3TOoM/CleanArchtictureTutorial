using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Queries
{
    public class GetAllProductsQuery
    {
        private readonly IProductRepoistery _repo;
        public GetAllProductsQuery(IProductRepoistery repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> Execute()
        {
            return _repo.GetAllProducts();
        }
    }
}
