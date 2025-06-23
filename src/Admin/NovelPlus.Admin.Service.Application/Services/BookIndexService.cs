using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 小说目录服务实现，用于管理目录信息的增删改查操作
/// </summary>
public class BookIndexService(IBookIndexRepository repository, ILogger<BookIndexService> logger) : IBookIndexService
{
    /// <summary>
    /// 目录仓储
    /// </summary>
    private readonly IBookIndexRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<BookIndexService> _logger = logger;

    /// <inheritdoc/>
    public Task<BookIndexEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<BookIndexEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(BookIndexEntity index)
    {
        _logger.LogInformation("Add book index {IndexName}", index.IndexName);
        return _repository.SaveAsync(index);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(BookIndexEntity index)
    {
        _logger.LogInformation("Update book index {Id}", index.Id);
        return _repository.UpdateAsync(index);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
