using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NovelPlus.Shared.Config;
using NovelPlus.Portal.Service.Domain.Entities;
using NovelPlus.Portal.Service.Domain.Repositories;

namespace NovelPlus.Portal.Service.Infrastructure.Repositories;

/// <summary>
/// NewsRepository 实现
/// </summary>
public class NewsRepository(ILogger<NewsRepository> logger, IOptionsMonitor<DatabaseConfig> options)
    : RepositoryBase<NewsEntity>(logger, options), INewsRepository
{
    /// <summary>
    /// 查询新闻
    /// </summary>
    /// <param name="id">新闻ID</param>
    /// <returns>新闻信息</returns>
    public Task<NewsEntity?> GetAsync(int id) => GetAsyncInternal(id);

    /// <summary>
    /// 新闻列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>新闻集合</returns>
    public Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query) => ListAsyncInternal(query);

    /// <summary>
    /// 新闻数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    public Task<int> CountAsync(Dictionary<string, object> query) => CountAsyncInternal(query);

    /// <summary>
    /// 新增新闻
    /// </summary>
    /// <param name="news">新闻实体</param>
    /// <returns>影响行数</returns>
    public Task<int> SaveAsync(NewsEntity news) => SaveAsyncInternal(news);

    /// <summary>
    /// 更新新闻
    /// </summary>
    /// <param name="news">新闻实体</param>
    /// <returns>影响行数</returns>
    public Task<int> UpdateAsync(NewsEntity news) => UpdateAsyncInternal(news);

    /// <summary>
    /// 删除新闻
    /// </summary>
    /// <param name="id">新闻ID</param>
    /// <returns>影响行数</returns>
    public Task<int> RemoveAsync(int id) => RemoveAsyncInternal(id);

    /// <summary>
    /// 批量删除新闻
    /// </summary>
    /// <param name="ids">新闻ID集合</param>
    /// <returns>影响行数</returns>
    public Task<int> BatchRemoveAsync(int[] ids) => BatchRemoveAsyncInternal(ids.Select(i => (long)i).ToArray());

    /// <summary>
    /// 增加阅读量
    /// </summary>
    /// <param name="newsId">新闻ID</param>
    public Task AddReadCountAsync(int newsId)
    {
        return Db.Updateable<NewsEntity>()
            .SetColumns(i => i.ReadCount == i.ReadCount + 1)
            .Where(i => i.Id == newsId)
            .ExecuteCommandAsync();
    }
}
