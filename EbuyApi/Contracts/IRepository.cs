using System.Collections.Generic;

namespace EbuyApi.Contracts
{
    public interface IRepository<Entity>
    {
        Entity Get(int id);
        IEnumerable<Entity> GetAll();
        void Add(Entity entity);
        void Delete(Entity entity);
    }
}