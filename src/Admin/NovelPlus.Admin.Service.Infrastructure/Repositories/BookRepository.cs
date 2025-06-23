using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// BookRepository 实现
/// </summary>
public class BookRepository(ILogger<BookRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<BookEntity>(logger, options), IBookRepository
{
    public Task<BookEntity?> GetAsync(long id) => GetAsyncInternal(id);
    public Task<List<BookEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);
    public Task<int> SaveAsync(BookEntity entity) => SaveAsyncInternal(entity);
    public Task<int> UpdateAsync(BookEntity entity) => UpdateAsyncInternal(entity);
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }
    /// <summary>
    /// 表数据统计
    /// </summary>
    public async Task<Dictionary<object, object>> TableStaAsync(DateTime minDate)
    {
        var sql = "SELECT DATE_FORMAT(create_time, '%Y-%m-%d') AS StaDate, COUNT(1) AS StaCount FROM Book WHERE create_time >= @MinDate GROUP BY DATE_FORMAT(create_time, '%Y-%m-%d') ORDER BY StaDate";
        var data = await Db.Ado.SqlQueryAsync<dynamic>(sql, new { MinDate = minDate });
        return data.ToDictionary(x => (object)x.StaDate, x => (object)x.StaCount);
    }
}
