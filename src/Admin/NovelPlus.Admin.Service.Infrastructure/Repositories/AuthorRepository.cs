using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using QYQ.Base.SqlSugar;
using NovelPlus.Admin.Service.Domain.Entities;
using NovelPlus.Admin.Service.Domain.Repositories;


namespace NovelPlus.Admin.Service.Infrastructure.Repositories;

/// <summary>
/// AuthorRepository 实现
/// </summary>
public class AuthorRepository(ILogger<AuthorRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<AuthorEntity>(logger, options), IAuthorRepository
{
    /// <summary>
    /// 查询单条记录
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>作者信息</returns>
    public Task<AuthorEntity?> GetAsync(long id) => GetAsyncInternal(id);

    /// <summary>
    /// 查询记录列表
    /// </summary>
    /// <param name="query">查询条件</param>
    /// <returns>作者集合</returns>
    public Task<List<AuthorEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 统计记录数量
    /// </summary>
    /// <param name="query">查询条件</param>
    /// <returns>记录数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增记录
    /// </summary>
    /// <param name="entity">作者实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(AuthorEntity entity) => SaveAsyncInternal(entity);

    /// <summary>
    /// 更新记录
    /// </summary>
    /// <param name="entity">作者实体</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(AuthorEntity entity) => UpdateAsyncInternal(entity);

    /// <summary>
    /// 删除记录
    /// </summary>
    /// <param name="id">主键</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(long id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除记录
    /// </summary>
    /// <param name="ids">主键集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(long[] ids)
    {
        return BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());
    }

    /// <summary>
    /// 表数据统计
    /// </summary>
    /// <param name="minDate">起始时间</param>
    /// <returns>日期-数量字典</returns>
    /// <remarks>使用 dynamic 是因为 SqlSugar 无法映射匿名列</remarks>
    public async Task<Dictionary<object, object>> TableStaAsync(DateTime minDate)
    {
        var sql = "SELECT DATE_FORMAT(create_time, '%Y-%m-%d') AS StaDate, COUNT(1) AS StaCount FROM Author WHERE create_time >= @MinDate GROUP BY DATE_FORMAT(create_time, '%Y-%m-%d') ORDER BY StaDate";
        var data = await Db.Ado.SqlQueryAsync<dynamic>(sql, new { MinDate = minDate });
        return data.ToDictionary(x => (object)x.StaDate, x => (object)x.StaCount);
    }
}
