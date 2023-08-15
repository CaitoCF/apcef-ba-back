using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities.Base;
using Apcef.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IContext _context;

        public Repository(IContext context)
        {
            ArgumentNullException.ThrowIfNull(nameof(context));

            _context = context;
        }

        public async Task<T> Create(T Entity, CancellationToken cancellationToken)
        {
            _context
                .GetDbSet<T>()
                .Add(Entity);

            Entity.CreationDate = DateTime.Now;

            await _context
                .UpdateDatabaseAsync(cancellationToken);

            return Entity;
        }

        public async Task Delete(Guid Id, CancellationToken cancellationToken)
        {
            T? Entity = await _context
                        .GetDbSet<T>()
                        .SingleOrDefaultAsync(s => s.Id.Equals(Id), cancellationToken);

            if (Entity is null)
            {
                return;
            }

            _context
                .GetDbSet<T>()
                .Remove(Entity);

            await _context.UpdateDatabaseAsync(cancellationToken);

        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await _context
                .GetDbSet<T>()
                .ToListAsync(cancellationToken);
        }

        public async Task<T?> GetById(Guid Id, CancellationToken cancellationToken)
        {
            return await _context
                .GetDbSet<T>()
                .FirstOrDefaultAsync(f => f.Id.Equals(Id), cancellationToken);
        }

        public async Task<T> Update(T Entity, CancellationToken cancellationToken)
        {
            _context.GetDbSet<T>().Update(Entity);
            Entity.ModifiedDate = DateTime.Now;
            await _context.UpdateDatabaseAsync(cancellationToken);

            return Entity;
        }
    }
}
