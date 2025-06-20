using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 新闻服务接口
/// </summary>
public interface INewsService
{
    Task<NewsEntity?> GetAsync(long id);

    Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(NewsEntity news);

    Task<int> UpdateAsync(NewsEntity news);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
