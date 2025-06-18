using UserService.Core;

var builder = WebApplication.CreateBuilder(args);

// 注册服务
builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddSingleton<IUserService, UserService.Core.UserService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

app.Run();
public partial class Program { }
