using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// UserReadHistoryRepository 实现
/// </summary>
public class UserReadHistoryRepository(ILogger<UserReadHistoryRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<UserReadHistoryEntity>(logger, options), IUserReadHistoryRepository
{
    /// <summary>
    /// 查询阅读记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>阅读记录</returns>
    public Task<UserReadHistoryEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 阅读记录列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>阅读记录集合</returns>
    public Task<List<UserReadHistoryEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 阅读记录数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增阅读记录
    /// </summary>
    /// <param name="entity">阅读记录</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(UserReadHistoryEntity entity) => SaveAsyncInternal(entity);

    /// <summary>
    /// 更新阅读记录
    /// </summary>
    /// <param name="entity">阅读记录</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(UserReadHistoryEntity entity) => UpdateAsyncInternal(entity);

    /// <summary>
    /// 删除阅读记录
    /// </summary>
    /// <param name="id">记录ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除阅读记录
    /// </summary>
    /// <param name="ids">记录ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 查询用户阅读记录
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>阅读记录集合</returns>
    public Task<List<UserReadHistoryEntity>> ListReadHistoryAsync(long userId)
    {
        return Db.Queryable<UserReadHistoryEntity>()
            .Where(i => i.UserId == userId)
            .OrderBy(i => i.CreateTime, OrderByType.Desc)
            .ToListAsync();
    }
}
