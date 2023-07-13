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
    endpoints.Map("employee/profile/{employeename :minlength(3):maxlength(7)=Riajul}", async context =>
    {
        string? employeeName = Convert.ToString(context.Request.RouteValues["employeename"]);
        await context.Response.WriteAsync($"In Employee profiles - {employeeName}");
    });
    //Eg: products/details/{id}
    endpoints.Map("products/details/{id?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {

            int Id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"In Products details - {Id}");
        }
        else
        {
            await context.Response.WriteAsync($"Product id is not supplied");
        }
    });
    //Eg: daily-digest-report/{reportdate}
    endpoints.Map("daily-digest-report/{reportdate:datetime}",async context =>
    {
        DateTime reportDate =Convert.ToDateTime(context.Request.RouteValues["reportdate"]);
        await context.Response.WriteAsync($"In Daily Digest report - {reportDate.ToShortDateString()}");  
    });
    //Eg: cities/cityid(guid)
    endpoints.Map("cities/{cityid:guid}",async context =>
    {
        Guid cityId = Guid.Parse(Convert.ToString(context.Request.RouteValues["cityid"])!);
        await context.Response.WriteAsync($"City Information - {cityId}");
    });
    //sales-report/2030/apr
    endpoints.Map("sales-report/{year:int:min(1900)}/{month:regex(^(apr|jul|oct|jan)$)}", async context =>
    {

        int year = Convert.ToInt32(context.Request.RouteValues["year"]);
        string? month = Convert.ToString(context.Request.RouteValues["month"]);

        if (month == "apr" || month == "jul" || month == "oct" || month == "jan")
        {
            await context.Response.WriteAsync($"sales report - {year} - {month}");
        }
        else
        {
            await context.Response.WriteAsync($"{month} is not allowed for sales report");
        }
    });
});

app.Run(async context =>
{
    await context.Response.WriteAsync($"No route matched at " +
        $"{context.Request.Path}");
});

app.Run();
