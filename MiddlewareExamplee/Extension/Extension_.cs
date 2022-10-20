using Microsoft.AspNetCore.Builder;
using MiddlewareExamplee.Middlewares;

namespace MiddlewareExamplee.Extension
{
    static public class Extension_
    {
        public static IApplicationBuilder UseHello( this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HelloMiddleware>();
        }
    }
}
