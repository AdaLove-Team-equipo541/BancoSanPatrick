using SanPatrick.Api.Middlewares;

namespace SanPatrick.Api.Extensions
{
    public static class ApplicationExtensions
    {
        public static void UseErrorHandlerMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
