using Microsoft.EntityFrameworkCore;

namespace PezPez.Infrastructure.Persistence.Contexts;

public class PezPezDbContext : DbContext
{
    public PezPezDbContext(DbContextOptions<PezPezDbContext> options) : base(options)
    {
    }
}