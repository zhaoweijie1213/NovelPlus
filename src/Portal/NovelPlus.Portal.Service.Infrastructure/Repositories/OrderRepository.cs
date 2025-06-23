using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// OrderRepository 实现
/// </summary>
public class OrderRepository(ILogger<OrderRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<OrderPayEntity>(logger, options), IOrderRepository
{
    /// <summary>
    /// 新增订单
    /// </summary>
    /// <param name="order">订单实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(OrderPayEntity order) => SaveAsyncInternal(order);
}
