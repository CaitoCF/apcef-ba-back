using Apcef.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.Context
{
    public interface IContext
    {

        public DbSet<T> GetDbSet<T>() where T : Entity;

        public Task UpdateDatabaseAsync(CancellationToken cancellationToken);

    }
}
