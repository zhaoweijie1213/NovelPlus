using NovelPlus.Portal.Service.Application.Interfaces;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Application.Services;

/// <summary>
/// 章节内容服务实现
/// </summary>
public class BookContentService(IBookContentRepository repository) : IBookContentService
{
    private readonly IBookContentRepository _repository = repository;

    /// <inheritdoc/>
    public Task<BookContentEntity?> QueryBookContentAsync(long bookId, long bookIndexId)
        => _repository.GetByBookAndIndexAsync(bookId, bookIndexId);
}
