using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// UserBookshelfRepository 实现
/// </summary>
public class UserBookshelfRepository(ILogger<UserBookshelfRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<UserBookshelfEntity>(logger, options), IUserBookshelfRepository
{
    /// <summary>
    /// 查询书架记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>书架记录</returns>
    public Task<UserBookshelfEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 书架列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>书架集合</returns>
    public Task<List<UserBookshelfEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 书架数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增书架记录
    /// </summary>
    /// <param name="entity">书架记录</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(UserBookshelfEntity entity) => SaveAsyncInternal(entity);

    /// <summary>
    /// 更新书架记录
    /// </summary>
    /// <param name="entity">书架记录</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(UserBookshelfEntity entity) => UpdateAsyncInternal(entity);

    /// <summary>
    /// 删除书架记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除书架记录
    /// </summary>
    /// <param name="ids">记录ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 查询用户书架
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>书架集合</returns>
    public Task<List<UserBookshelfEntity>> ListBookShelfAsync(long userId)
    {
        return Db.Queryable<UserBookshelfEntity>()
            .Where(i => i.UserId == userId)
            .OrderBy(i => i.CreateTime, OrderByType.Desc)
            .ToListAsync();
    }
}
