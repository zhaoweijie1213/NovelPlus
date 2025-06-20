using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 网站信息仓储接口
/// </summary>
public interface IWebsiteInfoRepository
{
    Task<WebsiteInfoEntity?> GetAsync(long id);

    Task<List<WebsiteInfoEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(WebsiteInfoEntity info);

    Task<int> UpdateAsync(WebsiteInfoEntity info);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
