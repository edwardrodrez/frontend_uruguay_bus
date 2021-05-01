using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using UruguayBus.Data;

namespace UruguayBus.Controllers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MiddlewareToken
    {
        private readonly RequestDelegate _next;
        Temp data = Temp.Instance;
        public MiddlewareToken(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            data.AcUs(httpContext.User.Identity.Name);
            httpContext.Request.Headers.Add("Authorization", "Bearer " + data.getToken());
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareTokenExtensions
    {
        public static IApplicationBuilder UseMiddlewareToken(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddlewareToken>();
        }
    }
}
