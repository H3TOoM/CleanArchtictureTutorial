using Application.DTOs;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IProductService
    {
        List<ProductDto> GetAllProducts();
        bool AddProduct(ProductDto dto);
    }
}
