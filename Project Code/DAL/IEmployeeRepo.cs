using BusinessLogicLayer.Class;

namespace DAL
{
    public interface IEmployeeRepo
    {
        Task AddProductAsync(Product product);
        Task<List<Product>> GetProductsAsync();
        Task UpdateProductStockAsync(int productId, int quantity);
    }
}