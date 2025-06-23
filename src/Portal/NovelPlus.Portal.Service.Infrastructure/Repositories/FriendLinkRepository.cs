using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// FriendLinkRepository 实现
/// </summary>
public class FriendLinkRepository(ILogger<FriendLinkRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<FriendLinkEntity>(logger, options), IFriendLinkRepository
{
    /// <inheritdoc/>
    public Task<List<FriendLinkEntity>> ListIndexLinkAsync()
    {
        return Db.Queryable<FriendLinkEntity>()
            .Where(i => i.IsOpen == 1)
            .OrderBy(i => i.Sort)
            .ToListAsync();
    }
}
