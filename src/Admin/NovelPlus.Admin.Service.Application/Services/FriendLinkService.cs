using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 友情链接服务实现
/// </summary>
public class FriendLinkService(IFriendLinkRepository repository, ILogger<FriendLinkService> logger) : IFriendLinkService
{
    private readonly IFriendLinkRepository _repository = repository;
    private readonly ILogger<FriendLinkService> _logger = logger;

    /// <inheritdoc/>
    public Task<FriendLinkEntity?> GetAsync(int id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<FriendLinkEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(FriendLinkEntity entity)
    {
        _logger.LogInformation("Add friend link {Name}", entity.LinkName);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(FriendLinkEntity entity)
    {
        _logger.LogInformation("Update friend link {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(int id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(int[] ids) => _repository.BatchRemoveAsync(ids);
}
