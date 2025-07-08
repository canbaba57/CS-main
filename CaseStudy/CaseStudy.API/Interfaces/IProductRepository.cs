using CaseStudy.API.Data;

namespace CaseStudy.API.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllAsyc();

        public Task<Product> GetByIdAsync(int id);
        public Task<Product> Create(Product product);

        public Task UpdateAsync(Product product);
        public Task RemoveAsync(int id);

    }
}
