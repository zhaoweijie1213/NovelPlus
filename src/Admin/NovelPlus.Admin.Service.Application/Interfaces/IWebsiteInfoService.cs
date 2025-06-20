using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 网站信息服务接口
/// </summary>
public interface IWebsiteInfoService
{
    Task<WebsiteInfoEntity?> GetAsync(long id);

    Task<List<WebsiteInfoEntity>> ListAsync(Dictionary<string, object> query);

    Task<int> CountAsync(Dictionary<string, object> query);

    Task<int> SaveAsync(WebsiteInfoEntity info);

    Task<int> UpdateAsync(WebsiteInfoEntity info);

    Task<int> RemoveAsync(long id);

    Task<int> BatchRemoveAsync(long[] ids);
}
