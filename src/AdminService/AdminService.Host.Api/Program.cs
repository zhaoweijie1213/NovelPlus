using AdminService.Service.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSwag;
using QYQ.Base.Swagger.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IAdminService, AdminService.Service.Application.AdminService>();

builder.Services.AddEndpointsApiExplorer();
builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo { Title = "Admin API", Version = "v1" });

var app = builder.Build();

app.MapControllers();
app.UseQYQSwaggerUI("Admin");

app.Run();

public partial class Program { }
