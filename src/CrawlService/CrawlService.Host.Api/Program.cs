using CrawlService.Service.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NSwag;
using QYQ.Base.Swagger.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<ISpiderService, CrawlService.Service.Application.SpiderService>();

builder.Services.AddEndpointsApiExplorer();
builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo { Title = "Crawl API", Version = "v1" });

var app = builder.Build();

app.MapControllers();
app.UseQYQSwaggerUI("Crawl");

app.Run();

public partial class Program { }
