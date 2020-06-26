using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace jatek_pont_net.Domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        public IArRepository ArRepository { get;}
        Task Commit();
    }
}
