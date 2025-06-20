using System.Threading.Tasks;
using NovelPlus.Crawler.Service.Domain.Entities;

namespace NovelPlus.Crawler.Service.Domain.Repositories;

/// <summary>
/// 爬虫小说目录仓储接口
/// </summary>
public interface ICrawlBookIndexRepository
{
    /// <summary>
    /// 查询最后的章节
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <returns>最后章节信息</returns>
    Task<BookIndexEntity?> QueryLastIndexAsync(long bookId);
}
