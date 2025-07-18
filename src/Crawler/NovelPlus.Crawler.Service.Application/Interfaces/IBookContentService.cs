using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Crawler.Service.Domain.Entities;

namespace NovelPlus.Crawler.Service.Application.Interfaces;

/// <summary>
/// 小说内容服务接口
/// </summary>
public interface IBookContentService
{
    /// <summary>
    /// 保存多个章节内容
    /// </summary>
    Task SaveBookContentAsync(List<BookContentEntity> bookContentList, long bookId);

    /// <summary>
    /// 保存章节内容
    /// </summary>
    Task SaveBookContentAsync(BookContentEntity bookContent, long bookId);

    /// <summary>
    /// 更新章节内容
    /// </summary>
    Task UpdateBookContentAsync(BookContentEntity bookContent, long bookId);
}
