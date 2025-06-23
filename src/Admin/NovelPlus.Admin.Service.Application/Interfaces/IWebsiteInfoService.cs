using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 网站信息服务接口
/// </summary>
public interface IWebsiteInfoService : IScopeDependency
{
    /// <summary>
    /// 查询单个网站信息
    /// </summary>
    Task<WebsiteInfoEntity?> GetAsync(long id);

    /// <summary>
    /// 查询网站信息列表
    /// </summary>
    Task<List<WebsiteInfoEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询网站信息数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增网站信息
    /// </summary>
    Task<int> SaveAsync(WebsiteInfoEntity info);

    /// <summary>
    /// 更新网站信息
    /// </summary>
    Task<int> UpdateAsync(WebsiteInfoEntity info);

    /// <summary>
    /// 删除网站信息
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除网站信息
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
