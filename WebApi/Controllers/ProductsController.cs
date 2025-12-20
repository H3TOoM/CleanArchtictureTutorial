using Application.Commands;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly CreateProductCommand _createProductCommand;
        public ProductsController(IProductService productService, CreateProductCommand createProductCommand)
        {
            _productService = productService;
            _createProductCommand = createProductCommand;
        }

        [HttpGet]
        public IActionResult GetAllProducts() 
        {
            var products = _productService.GetAllProducts();
            return Ok(products);       
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDto dto)
        {
            var result = await _createProductCommand.Excute(dto);
            if (result)
            {
                return Ok(dto);
            }
            return BadRequest();
        }

    }
}
