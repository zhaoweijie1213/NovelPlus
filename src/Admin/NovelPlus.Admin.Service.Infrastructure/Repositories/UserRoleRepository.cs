using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// UserRoleRepository 实现
/// </summary>
public class UserRoleRepository(ILogger<UserRoleRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysUserRoleEntity>(logger, options), IUserRoleRepository
{
    public Task<SysUserRoleEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysUserRoleEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysUserRoleEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysUserRoleEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
