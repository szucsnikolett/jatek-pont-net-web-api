using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jatek_pont_net.Domain.Repositories;

namespace jatek_pont_net.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly jatek_pont_netContext _context;
        public IArRepository ArRepository { get; private set; }

        public UnitOfWork(jatek_pont_netContext context,
                            IArRepository ar)
        {
            _context = context;
            ArRepository = ar;
        }
        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
