using BuildingBlocks.Common.Caching;
using BuildingBlocks.SharedKernel.Repositories;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;

namespace novels.Service.Infrastructure;

/// <summary>
/// 基础设施依赖注入扩展
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// 注册基础设施服务
    /// </summary>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ISqlSugarClient>(_ => new SqlSugarClient(new ConnectionConfig()));
        services.AddScoped(typeof(IGenericRepository<>), typeof(Repositories.SqlSugarRepository<>));
        services.AddSingleton<ICacheService, RedisCacheService>();
        services.AddSingleton<IDistributedLock, RedisDistributedLock>();
        return services;
    }
}
