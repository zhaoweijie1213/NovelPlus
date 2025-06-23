using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 新闻服务实现
/// </summary>
public class NewsService(INewsRepository repository, ILogger<NewsService> logger) : INewsService
{
    private readonly INewsRepository _repository = repository;
    private readonly ILogger<NewsService> _logger = logger;

    /// <inheritdoc/>
    public Task<NewsEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(NewsEntity entity)
    {
        _logger.LogInformation("Add news {Title}", entity.Title);
        return _repository.SaveAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(NewsEntity entity)
    {
        _logger.LogInformation("Update news {Id}", entity.Id);
        return _repository.UpdateAsync(entity);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
