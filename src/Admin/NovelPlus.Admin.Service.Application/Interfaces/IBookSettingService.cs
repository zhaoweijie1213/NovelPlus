using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Application.Interfaces;

/// <summary>
/// 首页小说设置服务接口
/// </summary>
public interface IBookSettingService : IScopeDependency
{
    /// <summary>
    /// 查询单个设置
    /// </summary>
    Task<BookSettingEntity?> GetAsync(long id);

    /// <summary>
    /// 查询设置列表
    /// </summary>
    Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 查询设置数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增设置
    /// </summary>
    Task<int> SaveAsync(BookSettingEntity setting);

    /// <summary>
    /// 更新设置
    /// </summary>
    Task<int> UpdateAsync(BookSettingEntity setting);

    /// <summary>
    /// 删除设置
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除设置
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
