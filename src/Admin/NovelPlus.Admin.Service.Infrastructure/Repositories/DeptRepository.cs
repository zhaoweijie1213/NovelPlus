using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// DeptRepository 实现
/// </summary>
public class DeptRepository(ILogger<DeptRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysDeptEntity>(logger, options), IDeptRepository
{
    public Task<SysDeptEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysDeptEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysDeptEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysDeptEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
