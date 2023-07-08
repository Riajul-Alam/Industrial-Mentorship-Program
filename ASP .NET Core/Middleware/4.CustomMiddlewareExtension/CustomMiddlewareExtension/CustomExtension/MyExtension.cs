namespace CustomMiddlewareExtension.CustomExtension
{
    public class MyExtension : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware started!\n\n");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware finished!\n\n");
        }
    }
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder MyExtension(this IApplicationBuilder app)
        {
            return app.UseMiddleware<MyExtension>();
        }
    }
}
