using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// BookCommentRepository 实现
/// </summary>
public class BookCommentRepository(ILogger<BookCommentRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookCommentEntity>(logger, options), IBookCommentRepository
{
    public Task<BookCommentEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<BookCommentEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(BookCommentEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(BookCommentEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
}
