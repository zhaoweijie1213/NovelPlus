using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 部门服务实现
/// </summary>
public class DeptService(IDeptRepository repository, ILogger<DeptService> logger) : IDeptService
{
    private readonly IDeptRepository _repository = repository;
    private readonly ILogger<DeptService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysDeptEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysDeptEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysDeptEntity entity)
    {
        _logger.LogInformation("Add dept {Name}", entity.Name);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysDeptEntity entity)
    {
        _logger.LogInformation("Update dept {Id}", entity.DeptId);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
