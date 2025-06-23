using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;
using System.Linq;

namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// FriendLinkRepository 实现
/// </summary>
public class FriendLinkRepository(ILogger<FriendLinkRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<FriendLinkEntity>(logger, options), IFriendLinkRepository
{
    public Task<FriendLinkEntity?> GetAsync(int id) => GetAsyncInternal(id);
    public Task<List<FriendLinkEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(FriendLinkEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(FriendLinkEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(int id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(int[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
