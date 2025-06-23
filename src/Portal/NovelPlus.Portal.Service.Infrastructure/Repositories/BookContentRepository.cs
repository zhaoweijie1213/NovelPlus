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
    /// <inheritdoc/>
    public async Task<BookContentEntity?> GetByBookAndIndexAsync(long bookId, long bookIndexId)
    {
        return await Db.Queryable<BookContentEntity>()
            .InnerJoin<BookIndexEntity>((c, i) => c.IndexId == i.Id)
            .Where((c, i) => i.BookId == bookId && i.Id == bookIndexId)
            .Select((c, _) => c)
            .FirstAsync();
    }
}
