using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 小说内容服务实现
/// </summary>
public class BookContentService(IBookContentRepository repository, ILogger<BookContentService> logger) : IBookContentService
{
    private readonly IBookContentRepository _repository = repository;
    private readonly ILogger<BookContentService> _logger = logger;

    /// <inheritdoc/>
    public Task<BookContentEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<BookContentEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(BookContentEntity content)
    {
        _logger.LogInformation("Add content for index {IndexId}", content.IndexId);
        return _repository.SaveAsync(content);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(BookContentEntity content)
    {
        _logger.LogInformation("Update content {Id}", content.Id);
        return _repository.UpdateAsync(content);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
