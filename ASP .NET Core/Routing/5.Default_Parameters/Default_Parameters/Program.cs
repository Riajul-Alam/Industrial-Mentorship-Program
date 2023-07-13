var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing 
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    //Eg: files/sample.txt
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? fileName = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync($"In Files - {fileName} - {extension}");
    });
    //Eg: employee/profile/john
    // here employeename = Riajul set for default value
    endpoints.Map("employee/profile/{employeename=Riajul}", async context =>
    {
        string employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In Employee profiles - {employeeName}");
    });
    //Eg: products/details/{id}
    endpoints.Map("products/details/{id=1}", async context =>
    {
        int Id = Convert.ToInt32(context.Request.RouteValues["id"]);
        await context.Response.WriteAsync($"In Products details - {Id}");
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at " +
        $"{context.Request.Path}");
});

app.Run();
