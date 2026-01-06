using Application.DTOs;
using Domain.Entites;
using Domain.Repoistiers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Commands
{
    //public record AddProductCommand(ProductDto Product); without MediatR
    public record AddProductCommand(ProductDto Product) : IRequest;//with MediatR

}
