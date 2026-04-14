using PezPez.Shared.Dtos;
using PezPez.Shared.Requests;

namespace PezPez.Application.Interfaces;

public interface IProductService
{
    Task<List<ProductDto>> GetAllAsync();
    Task<ProductDto?> GetByIdAsync(int id);
    Task<ProductDto> CreateAsync(CreateProductRequest request);
    Task<bool> UpdateAsync(UpdateProductRequest request);
    Task<bool> DeleteAsync(int id);
}