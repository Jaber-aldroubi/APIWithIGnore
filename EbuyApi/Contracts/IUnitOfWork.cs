namespace EbuyApi.Contracts
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        void Commit();
    }
}