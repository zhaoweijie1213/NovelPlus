using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// RoleDataPermRepository 实现
/// </summary>
public class RoleDataPermRepository(ILogger<RoleDataPermRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysRoleDataPermEntity>(logger, options), IRoleDataPermRepository
{
    /// <summary>
    /// 查询单条记录
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>实体信息</returns>
    public Task<SysRoleDataPermEntity?> GetAsync(long id) => GetAsyncInternal(id);
    /// <summary>
    /// 查询记录列表
    /// </summary>
    /// <param name="query">查询条件</param>
    /// <returns>实体集合</returns>
    public Task<List<SysRoleDataPermEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    /// <summary>
    /// 统计记录数量
    /// </summary>
    /// <param name="query">查询条件</param>
    /// <returns>记录数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    /// <summary>
    /// 新增记录
    /// </summary>
    /// <param name="entity">实体对象</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(SysRoleDataPermEntity entity) => SaveAsyncInternal(entity);
    /// <summary>
    /// 更新记录
    /// </summary>
    /// <param name="entity">实体对象</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(SysRoleDataPermEntity entity) => UpdateAsyncInternal(entity);
    /// <summary>
    /// 删除记录
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    /// <summary>
    /// 批量删除记录
    /// </summary>
    /// <param name="ids">主键集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
