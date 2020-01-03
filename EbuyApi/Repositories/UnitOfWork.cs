using EbuyApi.Contracts;
using EbuyApi.Model;

namespace EbuyApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository proRepo;
        private EBuyContext ebuyContext;
        public UnitOfWork(EBuyContext ebuyContext)
        {
            this.ebuyContext = ebuyContext;
        }

        public IProductRepository Products
        {
            get
            {
                return proRepo ?? (proRepo = new ProductRepository(ebuyContext));
            }
        }

        public void Commit()
        {
            ebuyContext.SaveChanges();
        }
    }
}
