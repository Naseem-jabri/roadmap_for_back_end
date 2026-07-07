using EshopAPI.Interfaces;
using EshopAPI.Models;
using Microsoft.AspNetCore.Mvc;
using EshopAPI.Dtos;

namespace EshopAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepo.GetAllAsync();
            var productDto = products.Select(p => ToProductDto(p));
            return Ok(productDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(ToProductDto(product));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product productModel)
        {
            var product = await _productRepo.CreateAsync(productModel);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpGet("{id}/comments")]
        public async Task<IActionResult> GetCommentsByProductId([FromRoute] int id)
        {
            var product = await _productRepo.GetByIdAsync(id);

            if (product == null) return NotFound("product not found");

            return Ok(product.Comments);
        }


        private static ProductDto ToProductDto(Product productModel)
        {
            return new ProductDto
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price ,

                Comments = productModel.Comments.Select(c => new CommentDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    Content = c.Content,
                    CreatedOn = c.CreatedOn
                }).ToList()
            };
        }
    }
}