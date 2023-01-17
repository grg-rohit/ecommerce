using ecommerceAPI.Data;
using ecommerceAPI.Entities;
using ecommerceAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ecommerceAPI.Repositories
{
    public class ProductRepository : IProductRepositroy
    {
        private readonly EcommerceDbContext ecommerceDbContext;

        public ProductRepository(EcommerceDbContext ecommerceDbContext)
        {
            this.ecommerceDbContext = ecommerceDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.ecommerceDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            try
            {
                //var procucts = await this.ecommerceDbContext.Products.include(p=>p.ProductCategory).ToListAsync();
                var products = await this.ecommerceDbContext.Products.ToListAsync();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
