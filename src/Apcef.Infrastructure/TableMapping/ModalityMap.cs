using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class ModalityMap : BaseMap
    {
        public ModalityMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Modality>("tb_modality", modelBuilder);

            modelBuilder
                .Entity<Modality>()
                .Property(x => x.Name)
                .HasColumnName("name");

        }
    }
}
