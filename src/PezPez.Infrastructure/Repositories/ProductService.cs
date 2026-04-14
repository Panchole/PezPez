using Microsoft.EntityFrameworkCore;
using PezPez.Application.Interfaces;
using PezPez.Infrastructure.Persistence.Contexts;
using PezPez.Infrastructure.Persistence.Entities;
using PezPez.Shared.Dtos;
using PezPez.Shared.Requests;

namespace PezPez.Infrastructure.Repositories;

public class ProductService : IProductService
{
    private readonly PezPezDbContext _context;

    public ProductService(PezPezDbContext context)
    {
        _context = context;
    }

    public async Task<List<ProductDto>> GetAllAsync()
    {
        return await _context.Products
            .AsNoTracking()
            .OrderBy(p => p.Name)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Stock = p.Stock,
                IsActive = p.IsActive
            })
            .ToListAsync();
    }

    public async Task<ProductDto?> GetByIdAsync(int id)
    {
        return await _context.Products
            .AsNoTracking()
            .Where(p => p.Id == id)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Stock = p.Stock,
                IsActive = p.IsActive
            })
            .FirstOrDefaultAsync();
    }

    public async Task<ProductDto> CreateAsync(CreateProductRequest request)
    {
        var entity = new Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            Stock = request.Stock,
            IsActive = request.IsActive,
            CreatedAt = DateTime.UtcNow
        };

        _context.Products.Add(entity);
        await _context.SaveChangesAsync();

        return new ProductDto
        {
            Id = entity.Id,
            Name = entity.Name,
            Description = entity.Description,
            Price = entity.Price,
            Stock = entity.Stock,
            IsActive = entity.IsActive
        };
    }

    public async Task<bool> UpdateAsync(UpdateProductRequest request)
    {
        var entity = await _context.Products.FirstOrDefaultAsync(p => p.Id == request.Id);

        if (entity is null)
            return false;

        entity.Name = request.Name;
        entity.Description = request.Description;
        entity.Price = request.Price;
        entity.Stock = request.Stock;
        entity.IsActive = request.IsActive;
        entity.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

        if (entity is null)
            return false;

        _context.Products.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}