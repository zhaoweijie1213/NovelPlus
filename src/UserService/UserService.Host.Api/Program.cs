using QYQ.Base.Swagger.Extension;
using UserService.Service.Application;

var builder = WebApplication.CreateBuilder(args);

// 注册服务
builder.Services.AddControllers();
builder.AddQYQSwaggerAndApiVersioning(new NSwag.OpenApiInfo()
{
    Title= "User API",
    Version = "v1"
});

builder.Services.AddSingleton<IUserService, UserService.Service.Application.UserService>();

var app = builder.Build();

app.UseQYQSwaggerUI("User");

app.MapControllers();

app.Run();
public partial class Program { }
