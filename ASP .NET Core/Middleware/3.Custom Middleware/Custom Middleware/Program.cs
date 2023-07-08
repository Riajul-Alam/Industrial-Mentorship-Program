
using Custom_Middleware.CustomMiddleware;
//1. Create an Instance of web application builder
var builder = WebApplication.CreateBuilder(args);

//Register custom middleware as a service
builder.Services.AddTransient<MyMiddleware>();
//2. Create an instance of WebApplication
var app = builder.Build();
//Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1 called\n\n");
    await next(context);
    //Code
});
//Middleware 2
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2 called\n\n");
    await next(context);
});
//Middleware 3 - Using custom middleware class
app.UseMiddleware<MyMiddleware>();
// Custom Middleware extension
//app.MyMiddleware();
//Middleware 5
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Middleware 4 called\n\n");
});
app.Run();