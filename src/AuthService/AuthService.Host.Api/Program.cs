using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AuthService.Service.Application;
using QYQ.Base.Swagger.Extension;
using NSwag;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IAuthService, AuthService.Service.Application.AuthService>();

builder.Services.AddEndpointsApiExplorer();
builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo { Title = "Auth API", Version = "v1" });

var app = builder.Build();

app.MapControllers();
app.UseQYQSwaggerUI("Auth");

app.Run();

public partial class Program { }
