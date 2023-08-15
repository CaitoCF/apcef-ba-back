using System.Text.Json.Serialization;

namespace Apcef.Domain.Entities.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
