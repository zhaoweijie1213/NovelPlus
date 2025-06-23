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
    /// <inheritdoc/>
    public Task<bool> ExistsPenNameAsync(string penName)
    {
        return Db.Queryable<AuthorEntity>().Where(a => a.PenName == penName).AnyAsync();
    }

    /// <inheritdoc/>
    public async Task<AuthorEntity?> QueryAuthorAsync(long userId)
    {
        return await Db.Queryable<AuthorEntity>().Where(a => a.UserId == userId).FirstAsync();
    }
}
