using EshopAPI.Data;
using EshopAPI.Interfaces;
using EshopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EshopAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
           
            return await _context.Products.Include(c => c.Comments).ToListAsync();
        }
        

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products
        .Include(p => p.Comments) 
        .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> CreateAsync(Product productModel)
        {
            await _context.Products.AddAsync(productModel);
            await _context.SaveChangesAsync();
            return productModel;
        }
    }
}