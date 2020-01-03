using EbuyApi.Contracts;
using EbuyApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace EbuyApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private EBuyContext db;

        public ProductRepository(EBuyContext db)
        {
            this.db = db;
        }

        public void Add(Product entity)
        {
            db.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            db.Products.Remove(entity);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetByBarcod(long barcode)
        {
            return db.Products.FirstOrDefault(pro => pro.Upc == barcode);
        }
    }
}