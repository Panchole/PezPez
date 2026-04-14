using PezPez.Infrastructure.DependencyInjection;
using PezPez.Shared.Dtos;
using PezPez.Shared.Responses;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddHealthChecks();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.MapGet("/health", () =>
{
    var response = ApiResponse<HealthCheckDto>.Ok(new HealthCheckDto
    {
        Status = "Healthy",
        Timestamp = DateTime.UtcNow
    }, "API running");

    return Results.Ok(response);
});

app.Run();