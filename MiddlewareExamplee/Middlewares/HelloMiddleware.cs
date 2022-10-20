using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MiddlewareExamplee.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate next;
        public HelloMiddleware(RequestDelegate _next)
        {
            next = _next;
        }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine("sa");
            await next.Invoke(context);
            Console.WriteLine("as");

        }
    }
}
