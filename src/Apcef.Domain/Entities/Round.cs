using Apcef.Domain.Entities.Base;

namespace Apcef.Domain.Entities
{
    public class Round : Entity
    {

        public string Name { get; set; }

        public Guid ModalityId { get; set; }

    }
}
