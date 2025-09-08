using ApplicationCore.Entities;
namespace ApplicationCore.Interfaces;
public interface IProductRepository
{
    Task<Product?> GetAsync(int id);
    Task<IReadOnlyList<Product>> ListAsync(int page = 1, int pageSize = 20);
    Task AddAsync(Product p);
}
