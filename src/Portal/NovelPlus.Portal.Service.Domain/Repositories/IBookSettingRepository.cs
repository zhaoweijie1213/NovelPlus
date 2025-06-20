using System.Collections.Generic;
using System.Threading.Tasks;
using NovelPlus.Portal.Service.Domain.Entities;

namespace NovelPlus.Portal.Service.Domain.Repositories;

/// <summary>
/// 首页小说设置仓储接口
/// </summary>
public interface IBookSettingRepository
{
    /// <summary>
    /// 查询首页设置
    /// </summary>
    /// <param name="id">设置ID</param>
    /// <returns>首页设置</returns>
    Task<BookSettingEntity?> GetAsync(long id);

    /// <summary>
    /// 设置列表
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>设置集合</returns>
    Task<List<BookSettingEntity>> ListAsync(Dictionary<string, object> query);

    /// <summary>
    /// 设置数量
    /// </summary>
    /// <param name="query">查询参数</param>
    /// <returns>数量</returns>
    Task<int> CountAsync(Dictionary<string, object> query);

    /// <summary>
    /// 新增首页设置
    /// </summary>
    /// <param name="setting">首页设置</param>
    Task<int> SaveAsync(BookSettingEntity setting);

    /// <summary>
    /// 更新首页设置
    /// </summary>
    /// <param name="setting">首页设置</param>
    Task<int> UpdateAsync(BookSettingEntity setting);

    /// <summary>
    /// 删除首页设置
    /// </summary>
    /// <param name="id">设置ID</param>
    Task<int> RemoveAsync(long id);

    /// <summary>
    /// 批量删除首页设置
    /// </summary>
    /// <param name="ids">设置ID集合</param>
    Task<int> BatchRemoveAsync(long[] ids);

    /// <summary>
    /// 查询首页设置
    /// </summary>
    /// <returns>首页设置集合</returns>
    Task<List<BookSettingEntity>> ListVoAsync();
}
