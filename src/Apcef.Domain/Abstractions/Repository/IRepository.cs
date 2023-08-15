using Apcef.Domain.Entities.Base;
using System.Threading.Tasks;

namespace Apcef.Domain.Abstractions.Repository
{
    public interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);

        Task<T?> GetById(Guid Id, CancellationToken cancellationToken);

        Task<T> Create(T Entity, CancellationToken cancellationToken);

        Task<T> Update(T Entity, CancellationToken cancellationToken);

        Task Delete(Guid Id, CancellationToken cancellationToken);
    }
}
