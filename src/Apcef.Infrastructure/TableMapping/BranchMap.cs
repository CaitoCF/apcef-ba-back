using Apcef.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public class BranchMap : BaseMap
    {

        public BranchMap(ModelBuilder modelBuilder)
        {
            ConfigureDefaults<Branch>("tb_branch",modelBuilder);

            modelBuilder
                .Entity<Branch>()
                .Property(p => p.Name)
                .HasColumnName("name")
                .IsRequired();

        }

    }
}
