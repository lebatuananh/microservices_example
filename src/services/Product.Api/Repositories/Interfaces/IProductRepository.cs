using Contracts.Common.Interfaces;
using Product.Api.Entities;
using Product.Api.Persistence;

namespace Product.Api.Repositories.Interfaces;

public interface IProductRepository : IRepositoryBaseAsync<CatalogProduct, long, ProductContext>
{
    Task<IEnumerable<CatalogProduct>> GetProducts();
    Task<CatalogProduct> GetProduct(long id);
    Task<CatalogProduct> GetProductByNo(string productNo);
    Task CreateProduct(CatalogProduct product);
    Task UpdateProduct(CatalogProduct product);
    Task DeleteProduct(long id);
}