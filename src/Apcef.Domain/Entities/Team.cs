using Apcef.Domain.Entities.Base;

namespace Apcef.Domain.Entities
{
    public class Team : Entity
    {

        public string Name { get; set; }
        public Guid ModalityId { get; set; }
        public Guid BranchId { get; set; }
        public Guid GroupId { get; set; }
        public int Points { get; set; }

    }
}
