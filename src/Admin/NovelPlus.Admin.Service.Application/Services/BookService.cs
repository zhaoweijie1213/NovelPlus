using Microsoft.Extensions.Logging;
using NovelPlus.Admin.Service.Application.Interfaces;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;

namespace NovelPlus.Admin.Service.Application.Services;

/// <summary>
/// 小说服务实现，用于管理小说基础信息的增删改查操作
/// </summary>
public class BookService(IBookRepository repository, ILogger<BookService> logger) : IBookService
{
    /// <summary>
    /// 小说仓储
    /// </summary>
    private readonly IBookRepository _repository = repository;
    /// <summary>
    /// 日志记录器
    /// </summary>
    private readonly ILogger<BookService> _logger = logger;

    /// <inheritdoc/>
    public Task<BookEntity?> GetAsync(long id) => _repository.GetAsync(id);

    /// <inheritdoc/>
    public Task<List<BookEntity>> ListAsync(Dictionary<string, object> query) => _repository.ListAsync(query);

    /// <inheritdoc/>
    public Task<int> CountAsync(Dictionary<string, object> query) => _repository.CountAsync(query);

    /// <inheritdoc/>
    public Task<int> SaveAsync(BookEntity book)
    {
        _logger.LogInformation("Add book: {Name}", book.BookName);
        return _repository.SaveAsync(book);
    }

    /// <inheritdoc/>
    public Task<int> UpdateAsync(BookEntity book)
    {
        _logger.LogInformation("Update book: {Id}", book.Id);
        return _repository.UpdateAsync(book);
    }

    /// <inheritdoc/>
    public Task<int> RemoveAsync(long id) => _repository.RemoveAsync(id);

    /// <inheritdoc/>
    public Task<int> BatchRemoveAsync(long[] ids) => _repository.BatchRemoveAsync(ids);

    /// <inheritdoc/>
    public Task<Dictionary<object, object>> TableStaAsync(DateTime minDate) => _repository.TableStaAsync(minDate);
}
