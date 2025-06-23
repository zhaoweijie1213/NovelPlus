using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;
using SqlSugar;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// AuthorRepository 实现
/// </summary>
public class AuthorRepository(ILogger<AuthorRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<AuthorEntity>(logger, options), IAuthorRepository
{
    /// <summary>
    /// 判断笔名是否存在
    /// </summary>
    /// <param name="penName">笔名</param>
    /// <returns>存在返回 true</returns>
    public Task<bool> ExistsPenNameAsync(string penName)
    {
        return Db.Queryable<AuthorEntity>().Where(a => a.PenName == penName).AnyAsync();
    }

    /// <summary>
    /// 根据用户ID查询作家
    /// </summary>
    /// <param name="userId">用户ID</param>
    /// <returns>作家实体或 null</returns>
    public async Task<AuthorEntity?> QueryAuthorAsync(long userId)
    {
        return await Db.Queryable<AuthorEntity>().Where(a => a.UserId == userId).FirstAsync();
    }
}
