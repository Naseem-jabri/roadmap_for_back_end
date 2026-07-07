using EshopAPI.Dtos;
using EshopAPI.Interfaces;
using EshopAPI.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/comment")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentRepository _commentRepo;
    private readonly IProductRepository _productRepo;

    public CommentController(ICommentRepository commentRepo, IProductRepository productRepo)
    {
        _commentRepo = commentRepo;
        _productRepo = productRepo;
    }

    [HttpPost("{productId}")]
    public async Task<IActionResult> Create([FromRoute] int productId, [FromBody] CommentDto commentDto)
    {
        var product = await _productRepo.GetByIdAsync(productId);
        if (product == null) return BadRequest( "not found ");

        var commentModel = new Comment
        {
            Title = commentDto.Title,
            Content = commentDto.Content,
            ProductId = productId
        };

        await _commentRepo.CreateAsync(commentModel);

        return Ok(commentModel);
    }
}