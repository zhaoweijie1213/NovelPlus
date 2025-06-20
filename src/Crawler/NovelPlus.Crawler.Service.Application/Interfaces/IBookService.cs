using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Crawler.Service.Domain.Entities;

namespace NovelPlus.Crawler.Service.Application.Interfaces;

/// <summary>
/// 小说服务接口
/// </summary>
public interface IBookService
{
    /// <summary>
    /// 根据小说名和作者名查询是否存在
    /// </summary>
    Task<bool> QueryIsExistByBookNameAndAuthorNameAsync(string bookName, string authorName);

    /// <summary>
    /// 更新书籍的爬虫属性
    /// </summary>
    Task UpdateCrawlPropertiesAsync(long id, int sourceId, string bookId);

    /// <summary>
    /// 通过分类ID查询分类名
    /// </summary>
    Task<string?> QueryCatNameByCatIdAsync(int catId);

    /// <summary>
    /// 保存小说以及目录和内容
    /// </summary>
    Task SaveBookAndIndexAndContentAsync(BookEntity book, List<BookIndexEntity> bookIndexList, List<BookContentEntity> bookContentList);

    /// <summary>
    /// 查询需要更新的小说数据
    /// </summary>
    Task<List<BookEntity>> QueryNeedUpdateBookAsync(DateTime startDate, int limit);

    /// <summary>
    /// 查询已存在的章节
    /// </summary>
    Task<Dictionary<int, BookIndexEntity>> QueryExistBookIndexMapAsync(long bookId);

    /// <summary>
    /// 更新小说、目录和内容
    /// </summary>
    Task UpdateBookAndIndexAndContentAsync(BookEntity book, List<BookIndexEntity> bookIndexList, List<BookContentEntity> bookContentList, Dictionary<int, BookIndexEntity> existBookIndexMap);

    /// <summary>
    /// 更新最后一次抓取时间
    /// </summary>
    [Obsolete]
    Task UpdateCrawlLastTimeAsync(long bookId);

    /// <summary>
    /// 通过小说名和作者名查询书籍
    /// </summary>
    Task<BookEntity?> QueryBookByBookNameAndAuthorNameAsync(string bookName, string authorName);
}
