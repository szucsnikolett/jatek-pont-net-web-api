﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace jatek_pont_net.Domain.Repositories
{
    interface IRepository<TEntity> where TEntity : class
    {
        Task GetById(int id);

        Task<List<TEntity>> GetAll();

        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task Add(TEntity entity);

        Task Edit(TEntity entity);

        Task Remove(TEntity entity);

        
    }
}