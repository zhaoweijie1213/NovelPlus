using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 新闻服务接口
/// </summary>
public interface INewsService
{
    /// <summary>
    /// 查询单条新闻
    /// </summary>
    Task<NewsEntity?> GetAsync(long id);

    /// <summary>
    /// 查询新闻列表
    /// </summary>
    Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询新闻数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增新闻
    /// </summary>
    Task<int> SaveAsync(NewsEntity news);

    /// <summary>
    /// 更新新闻
    /// </summary>
    Task<int> UpdateAsync(NewsEntity news);

    /// <summary>
    /// 删除新闻
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除新闻
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
