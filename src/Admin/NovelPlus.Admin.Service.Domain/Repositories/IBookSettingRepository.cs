using NovelPlus.Admin.Service.Domain.Entities;
using QYQ.Base.Common.IOCExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NovelPlus.Admin.Service.Domain.Repositories;

/// <summary>
/// 首页小说设置仓储接口
/// </summary>
public interface IBookSettingRepository : ITransientDependency
{
    /// <summary>
    /// 查询首页设置
    /// </summary>
    Task<BookSettingEntity?> GetAsync(long id);

    /// <summary>
    /// 设置列表
    /// </summary>
    Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 设置数量
    /// </summary>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增首页设置
    /// </summary>
    Task<int> SaveAsync(BookSettingEntity setting);

    /// <summary>
    /// 更新首页设置
    /// </summary>
    Task<int> UpdateAsync(BookSettingEntity setting);

    /// <summary>
    /// 删除首页设置
    /// </summary>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除首页设置
    /// </summary>
    Task<int> BatchRemoveAsync(long[] ids);
}
