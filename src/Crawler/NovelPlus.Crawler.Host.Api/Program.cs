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

app.MapControllers();

app.Run();

/// <summary>
/// 爬虫 Host 项目的 Program 类。
/// </summary>
public partial class Program
{
    // 该部分类用于在其他文件中扩展 Program 的功能。
}
