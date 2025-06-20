using NovelPlus.Shared.Config;
using NSwag;
using QYQ.Base.Common.IOCExtensions;
using QYQ.Base.Swagger.Extension;

var builder = WebApplication.CreateBuilder(args);
builder.AddQYQSerilog();

builder.Services.Configure<DatabaseConfig>(builder.Configuration.GetSection("ConnectionStrings"));
// Add services to the container.
builder.Services.AddMultipleService("^NovelPlus.Crawler");

builder.Services.AddControllers();

builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo()
{
    Title = "NovelPlus Crawler"
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseQYQSwaggerUI("NovelPlusCrawler");

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
    // This partial class is used to allow for additional configurations or methods
    // to be added in other files without modifying this main Program.cs file.
}
