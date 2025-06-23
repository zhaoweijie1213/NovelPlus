using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// RoleMenuRepository 实现
/// </summary>
public class RoleMenuRepository(ILogger<RoleMenuRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysRoleMenuEntity>(logger, options), IRoleMenuRepository
{
    public Task<SysRoleMenuEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysRoleMenuEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysRoleMenuEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysRoleMenuEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
