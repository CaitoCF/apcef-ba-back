using Apcef.Domain.Entities.Base;

namespace Apcef.Domain.Entities
{
    public class Group : Entity
    {

        public string Name { get; set; }
        public Guid ModalityId { get; set; }


    }
}
