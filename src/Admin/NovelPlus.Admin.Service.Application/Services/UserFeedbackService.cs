using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 用户反馈服务实现，用于管理用户反馈信息的增删改查操作
/// </summary>
public class UserFeedbackService(IUserFeedbackRepository repository, ILogger<UserFeedbackService> logger) : IUserFeedbackService
{
    /// <summary>
    /// 用户反馈仓储
    /// </summary>
    private readonly IUserFeedbackRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<UserFeedbackService> _logger = logger;

    /// <inheritdoc/>
    public Task<UserFeedbackEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<UserFeedbackEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(UserFeedbackEntity entity)
    {
        _logger.LogInformation("Add feedback for user {UserId}", entity.UserId);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(UserFeedbackEntity entity)
    {
        _logger.LogInformation("Update feedback {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
