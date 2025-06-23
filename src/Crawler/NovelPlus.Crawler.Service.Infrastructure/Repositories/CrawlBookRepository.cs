using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Repositories;

namespace NovelPlus.Crawler.Service.Infrastructure.Repositories;

/// <summary>
/// 爬虫小说仓储实现
/// </summary>
public class CrawlBookRepository(ILogger<CrawlBookRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookEntity>(logger, options), ICrawlBookRepository
{
    /// <inheritdoc />
    public Task<List<BookEntity>> QueryNeedUpdateBookAsync(DateTime startDate, int limit)
    {
        return Db.Queryable<BookEntity>()
            .Where(i => i.LastIndexUpdateTime > startDate && i.CrawlSourceId != null)
            .OrderBy(i => i.CrawlLastTime)
            .Take(limit)
            .ToListAsync();
    }

    /// <inheritdoc />
    public Task<int?> QueryTotalWordCountAsync(long bookId)
    {
        return Db.Queryable<BookIndexEntity>()
            .Where(i => i.BookId == bookId)
            .SumAsync(i => i.WordCount);
    }

    /// <inheritdoc />
    public Task UpdateCrawlLastTimeAsync(List<BookEntity> books, DateTime currentDate)
    {
        return Db.Updateable(books)
            .SetColumns(i => i.CrawlLastTime == currentDate)
            .ExecuteCommandAsync();
    }
}
