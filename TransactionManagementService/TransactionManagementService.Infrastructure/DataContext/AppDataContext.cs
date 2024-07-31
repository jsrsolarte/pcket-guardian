using Microsoft.EntityFrameworkCore;
using TransactionManagementService.Domain.Model.Entities.Base;

namespace TransactionManagementService.Infrastructure.DataContext
{
    public class AppDataContext(DbContextOptions<AppDataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                return;
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDataContext).Assembly);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var type = entityType.ClrType;
                if (typeof(DomainEntity).IsAssignableFrom(type))
                {
                    modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn");
                    modelBuilder.Entity(entityType.Name).Property<DateTime>("LastModifiedOn");
                }
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
