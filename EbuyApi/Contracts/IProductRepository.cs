using EbuyApi.Model;

namespace EbuyApi.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetByBarcod(long upc);
    }
}