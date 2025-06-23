using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// BookSettingRepository 实现
/// </summary>
public class BookSettingRepository(ILogger<BookSettingRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookSettingEntity>(logger, options), IBookSettingRepository
{
    /// <summary>
    /// 查询首页设置
    /// </summary>
    /// <param name="id">设置ID</param>
    /// <returns>首页设置</returns>
    public Task<BookSettingEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 设置列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>设置集合</returns>
    public Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 设置数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增首页设置
    /// </summary>
    /// <param name="setting">首页设置</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(BookSettingEntity setting) => SaveAsyncInternal(setting);

    /// <summary>
    /// 更新首页设置
    /// </summary>
    /// <param name="setting">首页设置</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(BookSettingEntity setting) => UpdateAsyncInternal(setting);

    /// <summary>
    /// 删除首页设置
    /// </summary>
    /// <param name="id">设置ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除首页设置
    /// </summary>
    /// <param name="ids">设置ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids) => BatchRemoveAsyncInternal(ids);

    /// <summary>
    /// 查询首页设置
    /// </summary>
    /// <returns>首页设置集合</returns>
    public Task<List<BookSettingEntity>> ListVoAsync()
    {
        return Db.Queryable<BookSettingEntity>().OrderBy(i => i.Sort).ToListAsync();
    }
}
