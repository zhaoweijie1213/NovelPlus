using EasyCaching.Core.Configurations;
using EasyCaching.Redis;
using NovelPlus.Shared.Config;
using NSwag;
using QYQ.Base.Common.IOCExtensions;
using QYQ.Base.SnowId;
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
//Ñ©»¨Id×é¼þ
builder.Services.AddSnowIdRedisGenerator(builder.Configuration.GetSection("Redis").Get<RedisDBOptions>());
//ÅäÖÃRedis
builder.Services.AddEasyCaching(delegate (EasyCachingOptions options)
{
    options.UseRedis(delegate (RedisOptions config)
    {
        config.DBConfig = builder.Configuration.GetSection("Redis").Get<RedisDBOptions>();
    }, "DefaultRedis").WithMessagePack();
});

#region  CAP

builder.Services.AddCap(options =>
{
    var configuration = builder.Configuration;
    options.UseRabbitMQ(config =>
    {
        config.HostName = configuration["CAP:RabbitMQ:HostName"]!;
        config.Port = configuration.GetSection("CAP:RabbitMQ:Port").Get<int>();
        config.UserName = configuration["CAP:RabbitMQ:UserName"]!;
        config.Password = configuration["CAP:RabbitMQ:Password"]!;
        config.ExchangeName = configuration["CAP:RabbitMQ:ExchangeName"]!;
    });
    options.UseMySql(opt =>
    {
        opt.ConnectionString = configuration["SysCap"]!;
        opt.TableNamePrefix = AppDomain.CurrentDomain.FriendlyName;
    });
});

#endregion
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
