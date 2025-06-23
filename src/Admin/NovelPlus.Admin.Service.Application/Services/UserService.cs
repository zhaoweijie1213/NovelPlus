using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 用户服务实现，用于管理前台用户的增删改查操作
/// </summary>
public class UserService(IUserRepository repository, ILogger<UserService> logger) : IUserService
{
    /// <summary>
    /// 用户仓储
    /// </summary>
    private readonly IUserRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<UserService> _logger = logger;

    /// <inheritdoc/>
    public Task<UserEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<UserEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(UserEntity entity)
    {
        _logger.LogInformation("Add user {Name}", entity.Username);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(UserEntity entity)
    {
        _logger.LogInformation("Update user {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);

    /// <inheritdoc/>
    public Task<Dictionary<object, object>> TableStaAsync(DateTime minDate) => _repository.TableStaAsync(minDate);
}
