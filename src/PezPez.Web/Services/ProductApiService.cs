using System.Net.Http.Json;
using PezPez.Shared.Dtos;
using PezPez.Shared.Requests;
using PezPez.Shared.Responses;

namespace PezPez.Web.Services;

public class ProductApiService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ProductApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<List<ProductDto>> GetAllAsync()
    {
        var client = _httpClientFactory.CreateClient("PezPezApi");
        var response = await client.GetFromJsonAsync<ApiResponse<List<ProductDto>>>("/api/products");
        return response?.Data ?? new List<ProductDto>();
    }

    public async Task<ProductDto?> CreateAsync(CreateProductRequest request)
    {
        var client = _httpClientFactory.CreateClient("PezPezApi");
        var result = await client.PostAsJsonAsync("/api/products", request);
        var response = await result.Content.ReadFromJsonAsync<ApiResponse<ProductDto>>();
        return response?.Data;
    }

    public async Task<bool> UpdateAsync(UpdateProductRequest request)
    {
        var client = _httpClientFactory.CreateClient("PezPezApi");
        var result = await client.PutAsJsonAsync($"/api/products/{request.Id}", request);
        return result.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var client = _httpClientFactory.CreateClient("PezPezApi");
        var result = await client.DeleteAsync($"/api/products/{id}");
        return result.IsSuccessStatusCode;
    }
}