using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// MenuRepository 实现
/// </summary>
public class MenuRepository(ILogger<MenuRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysMenuEntity>(logger, options), IMenuRepository
{
    public Task<SysMenuEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysMenuEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysMenuEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysMenuEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
