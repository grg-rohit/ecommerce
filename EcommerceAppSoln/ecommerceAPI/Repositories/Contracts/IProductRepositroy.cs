using ecommerceAPI.Entities;

namespace ecommerceAPI.Repositories.Contracts
{
    public interface IProductRepositroy
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
