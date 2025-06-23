using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 作者服务实现
/// </summary>
public class AuthorService(IAuthorRepository repository, ILogger<AuthorService> logger) : IAuthorService
{
    private readonly IAuthorRepository _repository = repository;
    private readonly ILogger<AuthorService> _logger = logger;

    /// <inheritdoc/>
    public Task<AuthorEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<AuthorEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(AuthorEntity author)
    {
        _logger.LogInformation("Add author: {Name}", author.PenName);
        return _repository.SaveAsync(author);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(AuthorEntity author)
    {
        _logger.LogInformation("Update author: {Id}", author.Id);
        return _repository.UpdateAsync(author);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);

    /// <inheritdoc/>
    public Task<Dictionary<object, object>> TableStaAsync(DateTime minDate) => _repository.TableStaAsync(minDate);
}
