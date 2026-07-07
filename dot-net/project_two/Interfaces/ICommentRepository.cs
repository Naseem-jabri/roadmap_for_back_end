using EshopAPI.Models;

namespace EshopAPI.Interfaces
{
    public interface ICommentRepository
    {
        Task<Comment> CreateAsync(Comment commentModel);
    }
}
