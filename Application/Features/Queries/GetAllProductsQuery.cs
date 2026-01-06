using Domain.Entites;
using Domain.Repoistiers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Queries
{
    //public record GetAllProductsQuery(); without MediatR
    public record GetAllProductsQuery() : IRequest<List<Product>>;//with MediatR
}
