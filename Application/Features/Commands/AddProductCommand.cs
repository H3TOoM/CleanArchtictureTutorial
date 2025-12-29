using Application.DTOs;
using Domain.Entites;
using Domain.Repoistiers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Commands
{
    public class AddProductCommand
    {
        public ProductDto product { get; set; }
        
    }
}
