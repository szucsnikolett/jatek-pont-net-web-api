using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace jatek_pont_net.Domain.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);

        Task<List<TEntity>> GetAll();

        Task<List<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);

    }
}
