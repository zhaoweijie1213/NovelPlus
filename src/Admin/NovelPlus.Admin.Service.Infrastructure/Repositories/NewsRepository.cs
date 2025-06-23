using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// NewsRepository 实现
/// </summary>
public class NewsRepository(ILogger<NewsRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<NewsEntity>(logger, options), INewsRepository
{
    public Task<NewsEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(NewsEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(NewsEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
