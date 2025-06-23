using NovelPlus.Crawler.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Crawler.Service.Domain.Repositories;

/// <summary>
/// 爬虫小说仓储接口
/// </summary>
public interface ICrawlBookRepository : ITransientDependency
{
    /// <summary>
    /// 查询需要更新的小说集合
    /// </summary>
    /// <param name="startDate">最新更新时间的起始时间</param>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    Task<List<BookEntity>> QueryNeedUpdateBookAsync(DateTime startDate, int limit);

    /// <summary>
    /// 查询小说总字数
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <returns>小说总字数</returns>
    Task<int?> QueryTotalWordCountAsync(long bookId);

    /// <summary>
    /// 批量更新小说最后抓取时间
    /// </summary>
    /// <param name="books">需要更新的小说集合</param>
    /// <param name="currentDate">当前时间</param>
    Task UpdateCrawlLastTimeAsync(List<BookEntity> books, DateTime currentDate);
}
