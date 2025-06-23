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
    /// <summary>
    /// 查询首页友情链接
    /// </summary>
    /// <returns>友情链接集合</returns>
    public Task<List<FriendLinkEntity>> ListIndexLinkAsync()
    {
        return Db.Queryable<FriendLinkEntity>()
            .Where(i => i.IsOpen == 1)
            .OrderBy(i => i.Sort)
            .ToListAsync();
    }
}
