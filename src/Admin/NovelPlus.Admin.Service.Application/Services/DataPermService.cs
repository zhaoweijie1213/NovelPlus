using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 数据权限服务实现
/// </summary>
public class DataPermService(IDataPermRepository repository, ILogger<DataPermService> logger) : IDataPermService
{
    private readonly IDataPermRepository _repository = repository;
    private readonly ILogger<DataPermService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysDataPermEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysDataPermEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysDataPermEntity entity)
    {
        _logger.LogInformation("Add data perm {Name}", entity.Name);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysDataPermEntity entity)
    {
        _logger.LogInformation("Update data perm {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
