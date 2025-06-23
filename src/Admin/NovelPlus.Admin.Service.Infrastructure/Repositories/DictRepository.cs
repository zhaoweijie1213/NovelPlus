using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// DictRepository 实现
/// </summary>
public class DictRepository(ILogger<DictRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysDictEntity>(logger, options), IDictRepository
{
    public Task<SysDictEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysDictEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysDictEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysDictEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
