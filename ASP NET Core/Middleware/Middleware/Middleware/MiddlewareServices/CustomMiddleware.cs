﻿namespace Middleware.MiddlewareServices
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello Dear Readers from Custom Middleware!");
        }
    }
    public static class ClassWithNoImplementationMiddlewareExtensions
    {
        public static IApplicationBuilder UseClassWithNoImplementationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware>();
        }
    }
}
