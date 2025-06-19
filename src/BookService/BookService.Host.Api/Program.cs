using BookService.Service.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSwag;
using QYQ.Base.Swagger.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IBookService, BookService.Service.Application.BookService>();

builder.Services.AddEndpointsApiExplorer();
builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo { Title = "Book API", Version = "v1" });

var app = builder.Build();

app.MapControllers();
app.UseQYQSwaggerUI("Book");

app.Run();

public partial class Program { }
