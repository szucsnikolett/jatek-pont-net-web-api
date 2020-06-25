using System.Threading.Tasks;

namespace jatek_pont_net.Domain.Repositories
{
    internal interface ICrud<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity>Edit(TEntity entity);
        
        void Remove(TEntity entity);
    }
}
