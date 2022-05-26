using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SanPatrick.Application.Interfaces;
using SanPatrick.Persistence.Contexts;
using SanPatrick.Persistence.Repository;

namespace SanPatrick.Persistence
{
    public static class PersistenceServiceExtensions
    {
        public static void AddPersistenceServiceExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(
                    configuration.GetConnectionString("DefaultConnection"),
                    m => m.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)

                ));

            //AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            #region Repositories
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            #endregion
        }
    }
}
