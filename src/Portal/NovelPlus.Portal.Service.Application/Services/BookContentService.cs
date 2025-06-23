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

    /// <summary>
    /// 查询指定章节内容
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <param name="bookIndexId">章节ID</param>
    /// <returns>章节内容或 null</returns>
    public Task<BookContentEntity?> QueryBookContentAsync(long bookId, long bookIndexId)
        => _repository.GetByBookAndIndexAsync(bookId, bookIndexId);
}
