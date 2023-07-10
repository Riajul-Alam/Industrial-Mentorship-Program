var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing 
app.UseRouting();

//Creating end point
app.UseEndpoints(endpoints =>
{
    //add your end points
});

app.Run();
