using EshopAPI.Data;
using EshopAPI.Interfaces;
using EshopAPI.Models;

namespace EshopAPI.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDbContext _context;

        public CommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel); 
            await _context.SaveChangesAsync();             
            return commentModel;
        }
    }
}