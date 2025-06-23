using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;

namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// 仓储基类，封装基础的CRUD操作
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
public abstract class RepositoryBase<TEntity>(ILogger logger, IOptionsMonitor<DatabaseConfig> options)
    : BaseRepository<TEntity>(logger, options.CurrentValue.NovelPlus) where TEntity : class, new()
{
    protected async Task<TEntity?> GetAsyncInternal(long id)
    {
        return await Db.Queryable<TEntity>().InSingleAsync(id);
    }
    protected Task<List<TEntity>> ListAsyncInternal(Dictionary<string, object> _) => Db.Queryable<TEntity>().ToListAsync();
    protected Task<int> CountAsyncInternal(Dictionary<string, object> _) => Db.Queryable<TEntity>().CountAsync();
    protected Task<int> SaveAsyncInternal(TEntity entity) => Db.Insertable(entity).ExecuteCommandAsync();
    protected Task<int> UpdateAsyncInternal(TEntity entity) => Db.Updateable(entity).ExecuteCommandAsync();
    protected Task<int> RemoveAsyncInternal(long id) => Db.Deleteable<TEntity>().In(id).ExecuteCommandAsync();
    protected Task<int> BatchRemoveAsyncInternal(long[] ids) => Db.Deleteable<TEntity>().In(ids).ExecuteCommandAsync();
}
