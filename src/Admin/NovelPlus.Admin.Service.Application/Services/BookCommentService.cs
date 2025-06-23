using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 评论服务实现
/// </summary>
public class BookCommentService(IBookCommentRepository repository, ILogger<BookCommentService> logger) : IBookCommentService
{
    private readonly IBookCommentRepository _repository = repository;
    private readonly ILogger<BookCommentService> _logger = logger;

    /// <inheritdoc/>
    public Task<BookCommentEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(BookCommentEntity comment)
    {
        _logger.LogInformation("Add comment for book {BookId}", comment.BookId);
        return _repository.SaveAsync(comment);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(BookCommentEntity comment)
    {
        _logger.LogInformation("Update comment {Id}", comment.Id);
        return _repository.UpdateAsync(comment);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);
}
