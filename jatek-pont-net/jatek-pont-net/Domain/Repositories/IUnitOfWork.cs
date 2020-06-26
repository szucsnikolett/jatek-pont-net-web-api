using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace jatek_pont_net.Domain.Repositories
{
    internal interface IUnitOfWork : IDisposable
    {
        IArRepository ArRepository { get; }
        Task Commit();
    }
}
