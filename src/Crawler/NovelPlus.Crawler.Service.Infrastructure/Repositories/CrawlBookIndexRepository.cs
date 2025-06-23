using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Crawler.Service.Domain.Entities;
using NovelPlus.Crawler.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Crawler.Service.Infrastructure.Repositories;

/// <summary>
/// 爬虫小说目录仓储实现
/// </summary>
public class CrawlBookIndexRepository(ILogger<CrawlBookIndexRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookIndexEntity>(logger, options), ICrawlBookIndexRepository
{
    /// <summary>
    /// 查询最后的章节
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <returns>最后章节信息</returns>
    public async Task<BookIndexEntity?> QueryLastIndexAsync(long bookId)
    {
        return await Db.Queryable<BookIndexEntity>()
            .Where(i => i.BookId == bookId)
            .OrderBy(i => i.IndexNum, OrderByType.Desc)
            .FirstAsync();
    }
}
