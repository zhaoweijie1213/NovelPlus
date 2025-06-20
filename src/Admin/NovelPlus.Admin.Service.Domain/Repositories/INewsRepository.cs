using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 新闻仓储接口
/// </summary>
public interface INewsRepository
{
    Task<NewsEntity?> GetAsync(long id);

    Task<List<NewsEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(NewsEntity news);

    Task<int> UpdateAsync(NewsEntity news);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
