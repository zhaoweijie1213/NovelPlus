using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Admin.Service.Domain.Entities;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 网站信息仓储接口
/// </summary>
public interface IWebsiteInfoRepository
{
    /// <summary>
    /// 查询站点信息
    /// </summary>
    Task<WebsiteInfoEntity?> GetAsync(long id);

    /// <summary>
    /// 站点信息列表
    /// </summary>
    Task<List<WebsiteInfoEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 站点信息数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增站点信息
    /// </summary>
    Task<int> SaveAsync(WebsiteInfoEntity info);

    /// <summary>
    /// 更新站点信息
    /// </summary>
    Task<int> UpdateAsync(WebsiteInfoEntity info);

    /// <summary>
    /// 删除站点信息
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除站点信息
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
