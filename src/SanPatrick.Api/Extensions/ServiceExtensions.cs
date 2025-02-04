﻿using Microsoft.AspNetCore.Mvc;

namespace SanPatrick.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddApiVersionExtension(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            });
        }
    }
}
