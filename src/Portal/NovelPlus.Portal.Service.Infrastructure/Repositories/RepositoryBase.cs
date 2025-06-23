using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// 仓储基类，封装基础的CRUD操作
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
public abstract class RepositoryBase<TEntity>(ILogger logger, IOptionsMonitor<DatabaseConfig> options)
    : BaseRepository<TEntity>(logger, options.CurrentValue.NovelPlus) where TEntity : class, new()
{
    /// <summary>
    /// 根据主键查询实体
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>实体信息</returns>
    protected async Task<TEntity?> GetAsyncInternal(long id)
    {
        return await Db.Queryable<TEntity>().InSingleAsync(id);
    }

    /// <summary>
    /// 查询列表
    /// </summary>
    /// <param name="_">查询条件</param>
    /// <returns>实体集合</returns>
    protected Task<List<TEntity>> ListAsyncInternal(Dictionary<string, object> _) => Db.Queryable<TEntity>().ToListAsync();

    /// <summary>
    /// 统计数量
    /// </summary>
    /// <param name="_">查询条件</param>
    /// <returns>数量</returns>
    protected Task<int> CountAsyncInternal(Dictionary<string, object> _) => Db.Queryable<TEntity>().CountAsync();

    /// <summary>
    /// 新增实体
    /// </summary>
    /// <param name="entity">实体对象</param>
    /// <returns>影响行数</returns>
    protected Task<int> SaveAsyncInternal(TEntity entity) => Db.Insertable(entity).ExecuteCommandAsync();

    /// <summary>
    /// 更新实体
    /// </summary>
    /// <param name="entity">实体对象</param>
    /// <returns>影响行数</returns>
    protected Task<int> UpdateAsyncInternal(TEntity entity) => Db.Updateable(entity).ExecuteCommandAsync();

    /// <summary>
    /// 删除实体
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>影响行数</returns>
    protected Task<int> RemoveAsyncInternal(long id) => Db.Deleteable<TEntity>().In(id).ExecuteCommandAsync();

    /// <summary>
    /// 批量删除实体
    /// </summary>
    /// <param name="ids">主键集合</param>
    /// <returns>影响行数</returns>
    protected Task<int> BatchRemoveAsyncInternal(long[] ids) => Db.Deleteable<TEntity>().In(ids).ExecuteCommandAsync();
}
