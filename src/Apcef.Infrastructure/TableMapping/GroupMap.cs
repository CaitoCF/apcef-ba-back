using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class GroupMap : BaseMap
    {

        public GroupMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Group>("tb_group",modelBuilder);

            modelBuilder
                .Entity<Group>()
                .Property(p => p.Name)
                .HasColumnName("name");

            modelBuilder
                .Entity<Group>()
                .Property(p => p.ModalityId)
                .HasColumnName("modality_id");

        }

    }
}
