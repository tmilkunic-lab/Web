using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        await db.Database.MigrateAsync();

        if (!await db.Products.AnyAsync())
        {
            db.Products.AddRange(
                new Product { Sku = "1001", Name = "Exam Gloves", Price = 9.99m },
                new Product { Sku = "1002", Name = "Surgical Masks", Price = 14.50m }
            );
            await db.SaveChangesAsync();
        }
    }
}
