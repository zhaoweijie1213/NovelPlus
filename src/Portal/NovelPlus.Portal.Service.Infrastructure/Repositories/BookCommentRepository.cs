using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// BookCommentRepository 实现
/// </summary>
public class BookCommentRepository(ILogger<BookCommentRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookCommentEntity>(logger, options), IBookCommentRepository
{
    /// <summary>
    /// 查询评论
    /// </summary>
    /// <param name="id">评论ID</param>
    /// <returns>评论信息</returns>
    public Task<BookCommentEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 评论列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>评论集合</returns>
    public Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 评论数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增评论
    /// </summary>
    /// <param name="comment">评论实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(BookCommentEntity comment) => SaveAsyncInternal(comment);

    /// <summary>
    /// 更新评论
    /// </summary>
    /// <param name="comment">评论实体</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(BookCommentEntity comment) => UpdateAsyncInternal(comment);

    /// <summary>
    /// 删除评论
    /// </summary>
    /// <param name="id">评论ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除评论
    /// </summary>
    /// <param name="ids">评论ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 分页查询评论
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <param name="bookId">小说ID</param>
    /// <returns>评论集合</returns>
    public Task<List<BookCommentEntity>> ListCommentByPageAsync(long? userId, long? bookId)
    {
        var query = Db.Queryable<BookCommentEntity>();
        if (userId != null)
        {
            query = query.Where(i => i.CreateUserId == userId);
        }
        if (bookId != null)
        {
            query = query.Where(i => i.BookId == bookId);
        }
        return query.OrderBy(i => i.CreateTime, OrderByType.Desc).ToListAsync();
    }
}
