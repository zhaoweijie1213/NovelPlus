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
builder.Services.AddMultipleService("^NovelPlus.Admin");

builder.Services.AddControllers();

builder.AddQYQSwaggerAndApiVersioning(new OpenApiInfo()
{
    Title = "NovelPlus Admin"
});
// SnowId
builder.Services.AddSnowIdRedisGenerator(builder.Configuration.GetSection("Redis").Get<RedisDBOptions>());
// Redis
builder.Services.AddEasyCaching(delegate (EasyCachingOptions options)
{
    options.UseRedis(delegate (RedisOptions config)
    {
        config.DBConfig = builder.Configuration.GetSection("Redis").Get<RedisDBOptions>();
    }, "DefaultRedis").WithMessagePack("DefaultRedis");
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
        opt.ConnectionString = configuration["ConnectionStrings:SysCap"]!;
        opt.TableNamePrefix = AppDomain.CurrentDomain.FriendlyName;
    });
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseQYQSwaggerUI("NovelPlusAdmin");

app.UseAuthorization();

app.MapControllers();

app.Run();

/// <summary>
/// Host 项目的 Program 类，允许在其他文件中扩展。
/// </summary>
public partial class Program
{
    // 该部分类用于方便在其他文件中扩展 Program 的功能。
}
