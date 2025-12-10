using Application.DTOs;
using Application.Interfaces;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;   
        }

        [HttpGet]
        public IActionResult GetAllProducts() 
        {
            var products = _productService.GetAllProducts();
            return Ok(products);       
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDto dto)
        {
            _productService.AddProduct(dto);
            return Ok(dto);
        }

    }
}
