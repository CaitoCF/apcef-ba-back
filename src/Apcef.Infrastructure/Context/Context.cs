using Apcef.Domain.Abstractions.Repository;
using Apcef.Domain.Entities;
using Apcef.Domain.Entities.Base;
using Apcef.Infrastructure.TableMapping;
using Microsoft.EntityFrameworkCore;

namespace Apcef.Infrastructure.Context
{
    public class Context : DbContext, IContext
    {
        public Context()
        {
            
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=tcp:apcef-ba-db.database.windows.net,1433;Initial Catalog=apcef-ba-db;Persist Security Info=False;User ID=apcef-ba-user;Password=MznQp5JrvEEZYAD;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ModalityMap(modelBuilder);
            new RoundMap(modelBuilder);
            new TeamMap(modelBuilder);
            new GroupMap(modelBuilder);
            new BranchMap(modelBuilder);
            new MatchMap(modelBuilder);

        }

        public DbSet<T> GetDbSet<T>() where T : Entity
        {
            return Set<T>();
        }

        public async Task UpdateDatabaseAsync(CancellationToken cancellationToken)
        {
            await SaveChangesAsync(cancellationToken);
        }

        public DbSet<Modality> modalities { get; private set; }
        public DbSet<Round> rounds { get; private set; }
        public DbSet<Team> teams { get; private set; }
        public DbSet<Group> groups { get; private set; }
        public DbSet<Branch> branches { get; private set; }
        public DbSet<Match> matches { get; private set; }

    }
}
