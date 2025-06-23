using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 支付服务实现，用于处理付费相关的增删改查操作
/// </summary>
public class PayService(IPayRepository repository, ILogger<PayService> logger) : IPayService
{
    /// <summary>
    /// 支付仓储
    /// </summary>
    private readonly IPayRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<PayService> _logger = logger;

    /// <inheritdoc/>
    public Task<OrderPayEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<OrderPayEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(OrderPayEntity entity)
    {
        _logger.LogInformation("Add pay order {OrderNo}", entity.OutTradeNo);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(OrderPayEntity entity)
    {
        _logger.LogInformation("Update pay order {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);

    /// <inheritdoc/>
    public Task<Dictionary<object, object>> TableStaAsync(DateTime minDate) => _repository.TableStaAsync(minDate);
}
