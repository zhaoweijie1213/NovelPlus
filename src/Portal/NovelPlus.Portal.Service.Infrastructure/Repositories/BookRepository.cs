using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// BookRepository 实现
/// </summary>
public class BookRepository(ILogger<BookRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookEntity>(logger, options), IBookRepository
{
    /// <summary>
    /// 查询单本小说
    /// </summary>
    /// <param name="id">小说ID</param>
    /// <returns>小说信息</returns>
    public Task<BookEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 查询小说列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 查询小说数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>小说数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增小说
    /// </summary>
    /// <param name="book">小说实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(BookEntity book) => SaveAsyncInternal(book);

    /// <summary>
    /// 更新小说
    /// </summary>
    /// <param name="book">小说实体</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(BookEntity book) => UpdateAsyncInternal(book);

    /// <summary>
    /// 删除小说
    /// </summary>
    /// <param name="id">小说ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除小说
    /// </summary>
    /// <param name="ids">小说ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 分页搜索小说
    /// </summary>
    /// <param name="query">搜索参数</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> SearchByPageAsync(Dictionary<string, object> query)
    {
        var q = Db.Queryable<BookEntity>().Where(i => i.WordCount > 0);
        if (query.TryGetValue("keyword", out var kwObj) && kwObj is string keyword && !string.IsNullOrWhiteSpace(keyword))
        {
            q = q.Where(i => i.BookName.Contains(keyword) || i.AuthorName.Contains(keyword));
        }
        if (query.TryGetValue("workDirection", out var wdObj) && wdObj is byte workDirection)
        {
            q = q.Where(i => i.WorkDirection == workDirection);
        }
        if (query.TryGetValue("catId", out var catIdObj) && catIdObj is int catId)
        {
            q = q.Where(i => i.CatId == catId);
        }
        if (query.TryGetValue("isVip", out var isVipObj) && isVipObj is byte isVip)
        {
            q = q.Where(i => i.IsVip == isVip);
        }
        if (query.TryGetValue("bookStatus", out var bookStatusObj) && bookStatusObj is byte bookStatus)
        {
            q = q.Where(i => i.BookStatus == bookStatus);
        }
        if (query.TryGetValue("wordCountMin", out var minObj) && minObj is int wordCountMin)
        {
            q = q.Where(i => i.WordCount >= wordCountMin);
        }
        if (query.TryGetValue("wordCountMax", out var maxObj) && maxObj is int wordCountMax)
        {
            q = q.Where(i => i.WordCount < wordCountMax);
        }
        if (query.TryGetValue("updateTimeMin", out var updateObj) && updateObj is DateTime updateTimeMin)
        {
            q = q.Where(i => i.LastIndexUpdateTime >= updateTimeMin);
        }
        if (query.TryGetValue("sort", out var sortObj) && sortObj is string sort)
        {
            q = sort switch
            {
                "visit_count" => q.OrderByDescending(i => i.VisitCount),
                "score" => q.OrderByDescending(i => i.Score),
                "comment_count" => q.OrderByDescending(i => i.CommentCount),
                _ => q.OrderByDescending(i => i.LastIndexUpdateTime)
            };
        }
        return q.ToListAsync();
    }

    /// <summary>
    /// 增加点击量
    /// </summary>
    /// <param name="bookId">小说ID</param>
    /// <param name="visitCount">增加的点击量</param>
    public Task AddVisitCountAsync(long bookId, int visitCount)
    {
        return Db.Updateable<BookEntity>()
            .SetColumns(i => i.VisitCount == (i.VisitCount ?? 0) + visitCount)
            .Where(i => i.Id == bookId)
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 查询同分类推荐小说
    /// </summary>
    /// <param name="catId">分类ID</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> ListRecBookByCatIdAsync(int catId)
    {
        return Db.Queryable<BookEntity>()
            .Where(i => i.CatId == catId && i.WordCount > 0)
            .OrderBy(i => SqlFunc.GetRandom())
            .Take(4)
            .ToListAsync();
    }

    /// <summary>
    /// 增加评论数
    /// </summary>
    /// <param name="bookId">小说ID</param>
    public Task AddCommentCountAsync(long bookId)
    {
        return Db.Updateable<BookEntity>()
            .SetColumns(i => i.CommentCount == (i.CommentCount ?? 0) + 1)
            .Where(i => i.Id == bookId)
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 查询包含网络图片的小说
    /// </summary>
    /// <param name="localPicPrefix">本地图片前缀</param>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> QueryNetworkPicBooksAsync(string localPicPrefix, int limit)
    {
        return Db.Queryable<BookEntity>()
            .Where(i => i.PicUrl.StartsWith("http") && !i.PicUrl.Contains(localPicPrefix))
            .Take(limit)
            .ToListAsync();
    }

    /// <summary>
    /// 按评分随机查询小说
    /// </summary>
    /// <param name="limit">查询条数</param>
    /// <returns>小说集合</returns>
    public Task<List<BookEntity>> SelectIdsByScoreAndRandomAsync(int limit)
    {
        return Db.Queryable<BookEntity>()
            .OrderBy(i => i.Score)
            .OrderBy(i => SqlFunc.GetRandom())
            .Take(limit)
            .ToListAsync();
    }
}
