using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 系统用户服务实现，用于管理后台用户的增删改查操作
/// </summary>
public class SysUserService(ISysUserRepository repository, ILogger<SysUserService> logger) : ISysUserService
{
    /// <summary>
    /// 系统用户仓储
    /// </summary>
    private readonly ISysUserRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<SysUserService> _logger = logger;

    /// <inheritdoc/>
    public Task<SysUserEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<SysUserEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(SysUserEntity entity)
    {
        _logger.LogInformation("Add system user {Name}", entity.Username);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(SysUserEntity entity)
    {
        _logger.LogInformation("Update system user {Id}", entity.UserId);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
