using Apcef.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.TableMapping
{
    public abstract class BaseMap
    {

        public virtual void ConfigureDefaults<T>(string tableName, ModelBuilder modelBuilder) where T : Entity
        {
            modelBuilder
                .Entity<T>()
                .ToTable(tableName);

            modelBuilder
                .Entity<T>()
                .HasKey(x => x.Id)
                .HasName("id");

            modelBuilder
                .Entity<T>()
                .Property(p => p.ModifiedDate)
                .HasColumnType("datetime")
                .IsRequired(false)
                .HasColumnName("modification_date");

            modelBuilder
                .Entity<T>()
                .Property(p => p.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
        }

    }
}
