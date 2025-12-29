using Application.DTOs;
using Application.Features.Commands;
using Application.Features.Queries;
using Application.Interfaces;
using Domain.Entites;
using Domain.Repoistiers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AddProductCommandHandler _addProductHandler;
        private readonly GetAllProductsQueryHandler _getAllProductsHandler;

        public ProductsController(AddProductCommandHandler addProductHandler, GetAllProductsQueryHandler getAllProductsHandler)
        {
            _addProductHandler = addProductHandler;
            _getAllProductsHandler = getAllProductsHandler;
        }

        [HttpPost]
        public IActionResult Add(AddProductCommand command)
        {
            if (command == null)
                return BadRequest("Invalid product data.");

            var result = _addProductHandler.Handle(command);
            if (!result)
                return BadRequest("Failed to add product.");

            return Ok("Product added successfully.");
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _getAllProductsHandler.Handle();
            return Ok(products);
        }
    }
}
