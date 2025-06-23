using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// AuthorCodeRepository 实现
/// </summary>
public class AuthorCodeRepository(ILogger<AuthorCodeRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<AuthorCodeEntity>(logger, options), IAuthorCodeRepository
{
    public Task<AuthorCodeEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<AuthorCodeEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(AuthorCodeEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(AuthorCodeEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
