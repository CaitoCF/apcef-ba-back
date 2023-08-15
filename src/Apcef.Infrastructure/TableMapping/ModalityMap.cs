using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class ModalityMap : BaseMap
    {
        public ModalityMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Modality>("tb_sport_genre", modelBuilder);

            modelBuilder
                .Entity<Modality>()
                .Property(x => x.Name)
                .HasColumnName("name");

        }
    }
}
