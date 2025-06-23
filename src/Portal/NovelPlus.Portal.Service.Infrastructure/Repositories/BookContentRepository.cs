using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// BookContentRepository 实现
/// </summary>
public class BookContentRepository(ILogger<BookContentRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookContentEntity>(logger, options), IBookContentRepository
{
    /// <summary>
    /// 根据书籍和目录查询章节内容
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <param name="bookIndexId">章节ID</param>
    /// <returns>章节内容或 null</returns>
    public async Task<BookContentEntity?> GetByBookAndIndexAsync(long bookId, long bookIndexId)
    {
        return await Db.Queryable<BookContentEntity>()
            .InnerJoin<BookIndexEntity>((c, i) => c.IndexId == i.Id)
            .Where((c, i) => i.BookId == bookId && i.Id == bookIndexId)
            .Select((c, _) => c)
            .FirstAsync();
    }
}
