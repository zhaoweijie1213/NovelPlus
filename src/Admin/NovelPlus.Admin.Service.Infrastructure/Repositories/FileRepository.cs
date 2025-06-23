using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// FileRepository 实现
/// </summary>
public class FileRepository(ILogger<FileRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<SysFileEntity>(logger, options), IFileRepository
{
    public Task<SysFileEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<SysFileEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(SysFileEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(SysFileEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
