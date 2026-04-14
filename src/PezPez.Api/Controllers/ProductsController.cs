using Microsoft.AspNetCore.Mvc;
using PezPez.Application.Interfaces;
using PezPez.Shared.Dtos;
using PezPez.Shared.Requests;
using PezPez.Shared.Responses;

namespace PezPez.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<ApiResponse<List<ProductDto>>>> GetAll()
    {
        var products = await _productService.GetAllAsync();
        return Ok(ApiResponse<List<ProductDto>>.Ok(products));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ApiResponse<ProductDto>>> GetById(int id)
    {
        var product = await _productService.GetByIdAsync(id);

        if (product is null)
            return NotFound(ApiResponse<ProductDto>.Fail("Producto no encontrado."));

        return Ok(ApiResponse<ProductDto>.Ok(product));
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<ProductDto>>> Create([FromBody] CreateProductRequest request)
    {
        var created = await _productService.CreateAsync(request);
        return Ok(ApiResponse<ProductDto>.Ok(created, "Producto creado correctamente."));
    }

    [HttpPut("{id:int}")]
    public async Task<ActionResult<ApiResponse<string>>> Update(int id, [FromBody] UpdateProductRequest request)
    {
        if (id != request.Id)
            return BadRequest(ApiResponse<string>.Fail("El id de la ruta no coincide con el body."));

        var updated = await _productService.UpdateAsync(request);

        if (!updated)
            return NotFound(ApiResponse<string>.Fail("Producto no encontrado."));

        return Ok(ApiResponse<string>.Ok("OK", "Producto actualizado correctamente."));
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ApiResponse<string>>> Delete(int id)
    {
        var deleted = await _productService.DeleteAsync(id);

        if (!deleted)
            return NotFound(ApiResponse<string>.Fail("Producto no encontrado."));

        return Ok(ApiResponse<string>.Ok("OK", "Producto eliminado correctamente."));
    }
}