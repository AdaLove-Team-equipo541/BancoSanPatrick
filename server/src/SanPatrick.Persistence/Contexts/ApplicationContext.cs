using Microsoft.EntityFrameworkCore;
using SanPatrick.Application.Interfaces;
using SanPatrick.Domain.Common;
using SanPatrick.Domain.Entities;
using System.Reflection;

namespace SanPatrick.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        private readonly IDateTimeService _dateTimeService;

        public ApplicationContext(DbContextOptions<ApplicationContext> options, IDateTimeService dateTimeService) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTimeService = dateTimeService;
        }

        public DbSet<SavingsAccount> SavingsAccounts { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        
                        entry.Entity.CreatedAt = _dateTimeService.NowUTC;
                        entry.Entity.CreatedBy = "system";
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
