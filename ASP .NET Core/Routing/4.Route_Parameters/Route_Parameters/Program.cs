var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing 
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName=Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In Files - {fileName} - {extension}");
    });
    endpoints.Map("employee/profile/{employeename}", async context =>
    {
    string employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In Employee profiles - {employeeName}");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at " +
        $"{context.Request.Path}");
});

app.Run();
