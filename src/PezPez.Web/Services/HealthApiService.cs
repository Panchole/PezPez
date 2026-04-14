using PezPez.Shared.Dtos;
using PezPez.Shared.Responses;
using System.Net.Http.Json;

namespace PezPez.Web.Services;

public class HealthApiService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HealthApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<ApiResponse<HealthCheckDto>?> GetHealthAsync()
    {
        var client = _httpClientFactory.CreateClient("PezPezApi");
        return await client.GetFromJsonAsync<ApiResponse<HealthCheckDto>>("/health");
    }
}