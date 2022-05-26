using Microsoft.Extensions.DependencyInjection;
using SanPatrick.Application.Interfaces;
using SanPatrick.Shared.Service.DateTime;

namespace SanPatrick.Shared
{
    public static class SharedServiceExtensions
    {
        public static void AddSharedServicesExtensions(this IServiceCollection services)
        {
            services.AddTransient<IDateTimeService, DateTimeService>();
        }
    }
}
