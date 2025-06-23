using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// SysUserRepository 实现
/// </summary>
public class SysUserRepository(ILogger<SysUserRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysUserEntity>(logger, options), ISysUserRepository
{
    public Task<SysUserEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysUserEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysUserEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysUserEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
