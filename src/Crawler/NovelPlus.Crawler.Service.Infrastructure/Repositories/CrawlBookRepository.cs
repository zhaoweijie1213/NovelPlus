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
    /// <summary>
    /// 查询需要更新的小说数据
    /// </summary>
    /// <param name="startDate">最新更新时间的起始时间</param>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> QueryNeedUpdateBookAsync(DateTime startDate, int limit)
    {
        return Db.Queryable<BookEntity>()
            .Where(i => i.LastIndexUpdateTime > startDate && i.CrawlSourceId != null)
            .OrderBy(i => i.CrawlLastTime)
            .Take(limit)
            .ToListAsync();
    }

    /// <summary>
    /// 查询小说总字数
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <returns>小说总字数</returns>
    public Task<int?> QueryTotalWordCountAsync(long bookId)
    {
        return Db.Queryable<BookIndexEntity>()
            .Where(i => i.BookId == bookId)
            .SumAsync(i => i.WordCount);
    }

    /// <summary>
    /// 批量更新小说最后抓取时间
    /// </summary>
    /// <param name="books">需要更新的小说集合</param>
    /// <param name="currentDate">当前时间</param>
    public Task UpdateCrawlLastTimeAsync(List<BookEntity> books, DateTime currentDate)
    {
        return Db.Updateable(books)
            .SetColumns(i => i.CrawlLastTime == currentDate)
            .ExecuteCommandAsync();
    }
}
