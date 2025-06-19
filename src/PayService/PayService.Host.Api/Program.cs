using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSwag;
using PayService.Service.Application;
using QYQ.Base.Swagger.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IOrderService, PayService.Service.Application.OrderService>();

builder.Services.AddEndpointsApiExplorer();
builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo { Title = "Pay API", Version = "v1" });

var app = builder.Build();


app.UseQYQSwaggerUI("Pay");

app.MapControllers();
app.Run();

public partial class Program { }
