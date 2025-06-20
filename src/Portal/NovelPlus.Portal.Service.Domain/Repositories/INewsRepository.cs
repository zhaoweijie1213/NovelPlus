using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 新闻仓储接口
/// </summary>
public interface INewsRepository
{
    /// <summary>
    /// 查询新闻
    /// </summary>
    /// <param name="id">新闻ID</param>
    /// <returns>新闻信息</returns>
    Task<NewsEntity?> GetAsync(int id);

    /// <summary>
    /// 新闻列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>新闻集合</returns>
    Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新闻数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增新闻
    /// </summary>
    /// <param name="news">新闻实体</param>
    Task<int> SaveAsync(NewsEntity news);

    /// <summary>
    /// 更新新闻
    /// </summary>
    /// <param name="news">新闻实体</param>
    Task<int> UpdateAsync(NewsEntity news);

    /// <summary>
    /// 删除新闻
    /// </summary>
    /// <param name="id">新闻ID</param>
    Task<int> RemoveAsync(int id);

    /// <summary>
    /// 批量删除新闻
    /// </summary>
    /// <param name="ids">新闻ID集合</param>
    Task<int> BatchRemoveAsync(int[] ids);

    /// <summary>
    /// 增加阅读量
    /// </summary>
    /// <param name="newsId">新闻ID</param>
    Task AddReadCountAsync(int newsId);
}
